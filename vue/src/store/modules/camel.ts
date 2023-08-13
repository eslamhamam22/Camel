import {Store,Module,ActionContext} from 'vuex'
import ListModule from './list-module'
import ListState from './list-state'
import Camel from '../entities/camel'
import Ajax from '../../lib/ajax'
import PageResult from '@/store/entities/page-result';

interface CamelState extends ListState<Camel>{
    editCamel:Camel;
}
class CamelModule extends ListModule<CamelState,any,Camel>{
    state={
        totalCount:0,
        currentPage:1,
        pageSize:10,
        list: new Array<Camel>(),
        loading:false,
        editCamel:new Camel()
    }
    actions={
        async getAll(context:ActionContext<CamelState,any>,payload:any){
            context.state.loading=true;
            let reponse=await Ajax.get('/api/services/app/Camel/GetAll',{params:payload.data});
            context.state.loading=false;
            let page=reponse.data.result as PageResult<Camel>;
            context.state.totalCount=page.totalCount;
            context.state.list=page.items;
        },
        async create(context:ActionContext<CamelState,any>,payload:any){
            await Ajax.post('/api/services/app/Camel/Create',payload.data);
        },
        async update(context:ActionContext<CamelState,any>,payload:any){
            await Ajax.put('/api/services/app/Camel/Update',payload.data);
        },
        async delete(context:ActionContext<CamelState,any>,payload:any){
            await Ajax.delete('/api/services/app/Camel/Delete?Id='+payload.data.id);
        },
        async get(context:ActionContext<CamelState,any>,payload:any){
            debugger;
            let reponse=await Ajax.get('/api/services/app/Camel/GetCamelForEdit?Id='+payload.id);
            debugger;
            return reponse.data.result.camel as Camel;
        }
    };
    mutations={
        setCurrentPage(state:CamelState,page:number){
            state.currentPage=page;
        },
        setPageSize(state:CamelState,pagesize:number){
            state.pageSize=pagesize;
        },
        edit(state:CamelState,camel:Camel){
            state.editCamel=camel;
        }
    }
}
const camelModule=new CamelModule();
export default camelModule;