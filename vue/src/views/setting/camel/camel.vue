<template>
    <div>
        <Card dis-hover>
            <div class="page-body">
                <Form ref="queryForm" :label-width="90" label-position="left" inline>
                    <Row :gutter="16">
                        <Col span="8">
                            <FormItem :label="L('Keyword')+':'" style="width:100%">
                                <Input v-model="pagerequest.keyword" :placeholder="L('Description')"></Input>
                            </FormItem>
                        </Col>
                    </Row>
                    <Row>
                        <Button icon="ios-add" type="primary" size="large" @click="create">{{L('Add')}}</Button>
                        <Button icon="ios-search" type="primary" size="large" @click="getpage" class="toolbar-btn">{{L('Find')}}</Button>
                    </Row>
                </Form>
                <div class="margin-top-10">
                    <Table :loading="loading" :columns="columns" :no-data-text="L('NoDatas')" border :data="list">
                    </Table>
                    <Page  show-sizer class-name="fengpage" :total="totalCount" class="margin-top-10" @on-change="pageChange" @on-page-size-change="pagesizeChange" :page-size="pageSize" :current="currentPage"></Page>
                </div>
            </div>
        </Card>
        <create-camel v-model="createModalShow"  @save-success="getpage"></create-camel>
        <edit-camel v-model="editModalShow"  @save-success="getpage"></edit-camel>
    </div>
</template>
<script lang="ts">
    import { Component, Vue,Inject, Prop,Watch } from 'vue-property-decorator';
    import Util from '@/lib/util';
    import AbpBase from '@/lib/abpbase';
    import PageRequest from '@/store/entities/page-request';
    import CreateCamel from './create-camel.vue';
    import EditCamel from './edit-camel.vue';
    import appconst from '../../../lib/appconst';
   
    class PageCamelRequest extends PageRequest{
        keyword:string='';
    }
    
    @Component({
        components:{CreateCamel,EditCamel}
    })
    export default class Camels extends AbpBase{
        
        pagerequest:PageCamelRequest=new PageCamelRequest();
        createModalShow:boolean=false;
        editModalShow:boolean=false;

        get list(){
            return this.$store.state.camel.list;
        };
        get loading(){
            return this.$store.state.camel.loading;
        }
        create(){
            this.createModalShow=true;
        }
        edit(){
            this.editModalShow=true;
        }
        pageChange(page:number){
            this.$store.commit('camel/setCurrentPage',page);
            this.getpage();
        }
        pagesizeChange(pagesize:number){
            this.$store.commit('camel/setPageSize',pagesize);
            this.getpage();
        }
        async getpage(){
            
            this.pagerequest.maxResultCount=this.pageSize;
            this.pagerequest.skipCount=(this.currentPage-1)*this.pageSize;
            
            await this.$store.dispatch({
                type:'camel/getAll',
                data:this.pagerequest
            })
        }
        get pageSize(){
            return this.$store.state.camel.pageSize;
        }
        get totalCount(){
            return this.$store.state.camel.totalCount;
        }
        get currentPage(){
            return this.$store.state.camel.currentPage;
        }
        columns=[{
            title:this.L('Pages.Camels.Code'),
            key:'id'
        },{
            title:this.L('Pages.Camels.Video'),
            key:'video',
            render:(h:any,params:any)=>{
                return h('div',[
                    h('Button',{
                        props:{
                            type:'primary',
                            size:'small'
                        },
                        style:{
                            marginRight:'0px',
                            background: 'unset',
                            border: '0',
                            color: '#57a3f3'
                        },
                        on:{
                            click:()=>{
                                const baseUrl = appconst.remoteServiceBaseUrl + '/Resources/UploadFiles/';
                                const videoUrl = baseUrl + params.row.video;
                                window.open(videoUrl);
                            }
                        }
                    }, params.row.video)]);
            }
        },{
            title:this.L('Pages.Camels.Description'),
            key:'description'
        },{
            title:this.L('Actions'),
            key:'Actions',
            width:250,
            render:(h:any,params:any)=>{
                return h('div',[
                    h('Button',{
                        props:{
                            type:'info',
                            size:'small'
                        },
                        style:{
                            marginRight:'5px'
                        },
                        on:{
                            click:()=>{
                                window.location.href = '#/admin/camel/'+params.row.id;
                            }
                        }
                    },this.L('View')),
                    h('Button',{
                        props:{
                            type:'primary',
                            size:'small'
                        },
                        style:{
                            marginRight:'5px'
                        },
                        on:{
                            click:()=>{
                                this.$store.commit('camel/edit',params.row);
                                this.edit();
                            }
                        }
                    },this.L('Edit')),
                    h('Button',{
                        props:{
                            type:'error',
                            size:'small'
                        },
                        on:{
                            click:async ()=>{
                                this.$Modal.confirm({
                                        title:this.L('Tips'),
                                        content:this.L('DeleteRolesConfirm'),
                                        okText:this.L('Yes'),
                                        cancelText:this.L('No'),
                                        onOk:async()=>{
                                            await this.$store.dispatch({
                                                type:'camel/delete',
                                                data:params.row
                                            })
                                            await this.getpage();
                                        }
                                })
                            }
                        }
                    },this.L('Delete'))
                ])
            }
        }]
        async created(){
            this.getpage();
        }
    }
</script>