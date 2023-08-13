<template>
    <div>
        <Modal width="60"
         :title="L('Pages.Camels.CreateNew')"
         :value="value"
         @on-ok="uploadFile"
         @on-visible-change="visibleChange"
        >
            <Form ref="camelForm"  label-position="top" :rules="camelRule" :model="camel">
                <Tabs value="anthropometricMeasurement">
                    <TabPane :label="L('Pages.Camels.AnthropometricMeasurements')" name="anthropometricMeasurement">
                        <Row>
                         <Col span="7">
                            <FormItem :label="L('Pages.Camels.ShoulderHeight')" prop="shoulderHeight">
                                <InputNumber name="shoulderHeight" v-model="camel.anthropometric.shoulderHeight" @on-change="calcAnthropometricFunctions()"></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                            </FormItem>
                         </Col>
                         <Col span="7" offset="1">
                            <FormItem :label="L('Pages.Camels.ChestWidth')" prop="chestWidth">
                                <InputNumber name="chestWidth" v-model="camel.anthropometric.chestWidth" @on-change="calcAnthropometricFunctions()"></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                            </FormItem>
                         </Col>
                         <Col span="7" offset="1">
                            <FormItem :label="L('Pages.Camels.HumpGirth')" prop="humpGirth">
                                <InputNumber name="humpGirth" v-model="camel.anthropometric.humpGirth" @on-change="calcAnthropometricFunctions()"></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                            </FormItem>
                         </Col>
                         <Col span="7">
                            <FormItem :label="L('Pages.Camels.LiveWeight')" prop="liveWeight">
                                <InputNumber name="liveWeight"
                                    v-model="camel.anthropometric.liveWeight"
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled />
                                <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                            </FormItem>
                         </Col>
                         <Col span="7" offset="1">
                            <FormItem :label="L('Pages.Camels.CamelLength')" prop="camelLength">
                                <InputNumber name="shoulderHeight" v-model="camel.anthropometric.camelLength" @on-change="calcAnthropometricFunctions()"></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                            </FormItem>
                         </Col>
                         <Col span="7" offset="1">
                            <FormItem :label="L('Pages.Camels.BMI')" prop="bmi">
                                <InputNumber name="bmi" v-model="camel.anthropometric.bmi" :value="camel.anthropometric.bmi" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.KilogramPerSquareMeter") }}</span>
                            </FormItem>
                         </Col>
                        </Row>
                        <Row>
                         <Col span="7">
                            <FormItem :label="L('Pages.Camels.FatRatioCoefficient')" prop="fatRatioCoefficient">
                                <InputNumber name="fatRatioCoefficient" v-model="camel.anthropometric.fatRatioCoefficient" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                            </FormItem>
                         </Col>
                         <Col span="7" offset="1">
                            <FormItem :label="L('Pages.Camels.MuscleWeight')" prop="muscleWeight">
                                <InputNumber name="muscleWeight" v-model="camel.anthropometric.muscleWeight" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                            </FormItem>
                         </Col>
                        </Row>
                    </TabPane>
                    <TabPane :label="L('Pages.Camels.Details')" name="detail">
                         <Col span="11">
                            <FormItem :label="L('Pages.Camels.Description')" prop="description">
                                <textarea rows="5" style="width:100%;" class="ivu-input ivu-input-default" name="description" v-model="camel.description"></textarea>
                            </FormItem>
                         </Col>
                         <Col span="11" offset="1">
                            <Upload :before-upload="handleUpload" action="">
                                <Button icon="ios-cloud-upload-outline">Select the video to upload</Button>
                            </Upload>
                            <video :src="url" v-if="url" height="200" controls></video> <br />
                         </Col>
                    </TabPane>
                    <TabPane :label="L('Pages.Camels.MechanicalMeasurements')" name="mechanical">
                        <Row>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.TotalWeight')" prop="totalWeight">
                                    <InputNumber name="totalWeight" v-model="camel.mechanical.totalWeight" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.StrokeDistance')" prop="strokeDistance">
                                    <InputNumber name="strokeDistance" v-model="camel.mechanical.strokeDistance" @on-change="calcMechanicalFunctions()"></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Meter") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.Work')" prop="work">
                                    <InputNumber name="work" v-model="camel.mechanical.work" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Joule") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.StrokTime')" prop="strokTime">
                                    <InputNumber name="strokTime" v-model="camel.mechanical.strokTime" @on-change="calcMechanicalFunctions()"></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.GenralAbility')" prop="genralAbility">
                                    <InputNumber name="genralAbility" v-model="camel.mechanical.genralAbility" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.JoulePerSecond") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.Velocity')" prop="velocity">
                                    <InputNumber name="velocity" v-model="camel.mechanical.velocity" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.Gravity')" prop="gravity">
                                    <InputNumber name="gravity" v-model="camel.mechanical.gravity" @on-change="calcMechanicalFunctions()"></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.MeterPerSquareSecond") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.Mass')" prop="mass">
                                    <InputNumber name="mass" v-model="camel.mechanical.mass" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                </FormItem>
                            </Col>
                        </Row>
                    </TabPane>
                    <TabPane :label="L('Pages.Camels.CausalVariables')" name="causal">
                        <Row>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.Mass')" prop="mass">
                                    <InputNumber name="mass" v-model="camel.causal.mass" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.Velocity')" prop="velocity">
                                    <InputNumber name="velocity" v-model="camel.causal.velocity" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.MotionEnergy')" prop="kineticEnergy">
                                    <InputNumber name="kineticEnergy" v-model="camel.causal.kineticEnergy" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Joule") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.VectorDistance')" prop="vectorDistance">
                                    <InputNumber name="vectorDistance" v-model="camel.causal.vectorDistance" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Meter") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.VectorTime')" prop="vectorTime">
                                    <InputNumber name="vectorTime" v-model="camel.causal.vectorTime" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.VectorVelocity')" prop="vectorVelocity">
                                    <InputNumber name="vectorVelocity" v-model="camel.causal.vectorVelocity" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.LengthCycle')" prop="lengthCycle">
                                    <InputNumber name="lengthCycle" v-model="camel.causal.lengthCycle" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Meter") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.FrequencyCycle')" prop="frequencyCycle">
                                    <InputNumber name="frequencyCycle" v-model="camel.causal.frequencyCycle" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.FrequencyPerSecond") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.RateVelocity')" prop="rateVelocity">
                                    <InputNumber name="rateVelocity" v-model="camel.causal.rateVelocity" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.RightFrontFootSupportTime')" prop="rightFrontFootSupportTime">
                                    <InputNumber name="rightFrontFootSupportTime" v-model="camel.causal.rightFrontFootSupportTime" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.LeftFrontFootSupportTime')" prop="leftFrontFootSupportTime">
                                    <InputNumber name="leftFrontFootSupportTime" v-model="camel.causal.leftFrontFootSupportTime" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.RightFootSupportTime')" prop="rightFootSupportTime">
                                    <InputNumber name="rightFootSupportTime" v-model="camel.causal.rightFootSupportTime" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7">
                                <FormItem :label="L('Pages.Camels.LeftFootSupportTime')" prop="leftFootSupportTime">
                                    <InputNumber name="leftFootSupportTime" v-model="camel.causal.leftFootSupportTime" @on-change="calcCausalFunctions()"></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                </FormItem>
                            </Col>
                            <Col span="7" offset="1">
                                <FormItem :label="L('Pages.Camels.TotalStepCycleTime')" prop="totalStepCycleTime">
                                    <InputNumber name="totalStepCycleTime" v-model="camel.causal.totalStepCycleTime" 
                                    :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                    :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></InputNumber>
                                    <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                </FormItem>
                            </Col>
                        </Row>
                    </TabPane>
                </Tabs>
            </Form>
            <div slot="footer">
                <Button @click="cancel">{{L('Cancel')}}</Button>
                <Button @click="uploadFile" type="primary">{{L('OK')}}</Button>
            </div>
        </Modal>
    </div>
</template>
<style lang="less">
    @import '../../../styles/camels.less';
</style>
<script lang="ts">
    import { Component, Vue,Inject, Prop,Watch  } from 'vue-property-decorator';
    import Util from '../../../lib/util'
    import AbpBase from '../../../lib/abpbase'
    import Camel from '@/store/entities/camel';
    import AnthropometricMeasurement from '@/store/entities/anthropometric';
    import MechanicalMeasurement from '@/store/entities/mechanical';
    import CausalVariable from '@/store/entities/causal';
    import axios from 'axios';
    import appconst from '../../../lib/appconst';

    @Component
    export default class CreateCamel extends AbpBase{

        @Prop({type:Boolean,default:false}) value:boolean;
        camel:Camel=new Camel();
        url: string = "";
        file = null;

        async mounted() {
            console.log(`the component is now mounted.`)
        }

        async beforeCreate() {
            console.log(`the component is now before Create.`)
        }

        async beforeMount() {
            console.log(`the component is now before Mount.`)
        }

        async created(){
            this.camel.anthropometric = new AnthropometricMeasurement();
            this.camel.mechanical = new MechanicalMeasurement();
            this.camel.causal = new CausalVariable();
            console.log(`the component is now Create.`)
        }
           
        save(){
            debugger;
            (this.$refs.camelForm as any).validate(async (valid:boolean)=>{
                if(valid){
                    await this.$store.dispatch({
                        type:'camel/create',
                        data:this.camel
                    });
                    (this.$refs.camelForm as any).resetFields();
                    this.$emit('save-success');
                    this.$emit('input',false);
                }
            })
        }

        handleUpload (file) {
            debugger;
            this.file = file;
            this.url = URL.createObjectURL(file);
            this.$forceUpdate();
        }

        uploadFile() {
            debugger;
            if (this.file == undefined || this.file == null) {
                this.save();
                return;
            }
            let fileToUpload = this.file;
            const headers = { 'Content-Type': 'multipart/form-data' };
            const formData = new FormData();
            formData.append('file', fileToUpload, fileToUpload.name);
            axios.post(appconst.remoteServiceBaseUrl + '/api/upload/upload', formData, { headers })
                .then(event => {
                    this.camel.video = event.data.result.newFileName;
                    this.save();
                });
        }
    
        cancel(){
            (this.$refs.camelForm as any).resetFields();
            this.$emit('input',false);
        }

        visibleChange(value:boolean){
            if(!value){
                this.$emit('input',value);
            }
        }

        camelRule={
            
        }

       async calcMechanicalFunctions() {
            if (this.camel.mechanical.strokeDistance && this.camel.mechanical.totalWeight) {
                this.camel.mechanical.work = this.camel.mechanical.strokeDistance * this.camel.mechanical.totalWeight;
            }
            if (this.camel.mechanical.strokeDistance && this.camel.mechanical.totalWeight && this.camel.mechanical.strokTime) {
                this.camel.mechanical.genralAbility = this.camel.mechanical.strokeDistance / this.camel.mechanical.strokTime * this.camel.mechanical.totalWeight;
            }
            if (this.camel.mechanical.strokeDistance && this.camel.mechanical.strokTime) {
                this.camel.mechanical.velocity = this.camel.mechanical.strokeDistance / this.camel.mechanical.strokTime;
                this.camel.causal.velocity = this.camel.mechanical.velocity;
            }
            if (this.camel.mechanical.gravity && this.camel.mechanical.totalWeight) {
                this.camel.mechanical.mass = this.camel.mechanical.gravity * this.camel.mechanical.totalWeight;
                this.camel.causal.mass = this.camel.mechanical.mass;
            }
            await this.calcCausalFunctions();
            this.$forceUpdate();
        }

       async calcAnthropometricFunctions() {
            if (this.camel.anthropometric.shoulderHeight && this.camel.anthropometric.chestWidth && this.camel.anthropometric.humpGirth) {
                this.camel.anthropometric.liveWeight = this.camel.anthropometric.shoulderHeight * this.camel.anthropometric.chestWidth * this.camel.anthropometric.humpGirth;
                this.camel.mechanical.totalWeight = this.camel.anthropometric.liveWeight;
            }
            if (this.camel.anthropometric.camelLength && this.camel.anthropometric.liveWeight) {
                this.camel.anthropometric.bmi = this.camel.anthropometric.liveWeight / (this.camel.anthropometric.camelLength * this.camel.anthropometric.camelLength);
            }
            if (this.camel.anthropometric.liveWeight) {
                this.camel.anthropometric.fatRatioCoefficient = this.camel.anthropometric.liveWeight * 1.082 + 94.42;
            }
            if (this.camel.anthropometric.fatRatioCoefficient && this.camel.anthropometric.liveWeight) {
                this.camel.anthropometric.muscleWeight = this.camel.anthropometric.fatRatioCoefficient - 100 * this.camel.anthropometric.liveWeight * 45;
            }
            this.$forceUpdate();
        }
        
       async calcCausalFunctions() {
            if (this.camel.causal.mass && this.camel.causal.velocity) {
                this.camel.causal.kineticEnergy = this.camel.causal.mass * this.camel.causal.velocity * this.camel.causal.velocity * 0.5;
            }
            if (this.camel.causal.vectorDistance && this.camel.causal.vectorTime) {
                this.camel.causal.vectorVelocity = this.camel.causal.vectorDistance / this.camel.causal.vectorTime;
            }
            if (this.camel.causal.lengthCycle && this.camel.causal.frequencyCycle) {
                this.camel.causal.rateVelocity = this.camel.causal.lengthCycle * this.camel.causal.frequencyCycle;
            }
            if (this.camel.causal.rightFrontFootSupportTime && this.camel.causal.leftFrontFootSupportTime && this.camel.causal.rightFootSupportTime && this.camel.causal.leftFootSupportTime) {
                this.camel.causal.totalStepCycleTime = parseInt(this.camel.causal.rightFrontFootSupportTime.toString()) + 
                parseInt(this.camel.causal.leftFrontFootSupportTime.toString()) + parseInt(this.camel.causal.rightFootSupportTime.toString()) + 
                parseInt(this.camel.causal.leftFootSupportTime.toString());
            }
            this.$forceUpdate();
        }

    }
</script>

