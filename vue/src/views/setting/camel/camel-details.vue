<template>
    <div>
        <Card dis-hover>
            <div class="page-body">
                <Form ref="camelForm" label-position="top" :model="camel">
                    <Tabs value="anthropometricMeasurement">
                        <TabPane :label="L('Pages.Camels.AnthropometricMeasurements')" name="anthropometricMeasurement">
                            <Row>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.ShoulderHeight')" prop="shoulderHeight">
                                        <Input name="shoulderHeight" v-model="camel.anthropometric.shoulderHeight" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.ChestWidth')" prop="chestWidth">
                                        <Input name="chestWidth" v-model="camel.anthropometric.chestWidth" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.HumpGirth')" prop="humpGirth">
                                        <Input name="humpGirth" v-model="camel.anthropometric.humpGirth" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.LiveWeight')" prop="liveWeight">
                                        <Input name="liveWeight"
                                            v-model="camel.anthropometric.liveWeight"
                                            :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                            :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled />
                                        <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.CamelLength')" prop="camelLength">
                                        <Input name="shoulderHeight" v-model="camel.anthropometric.camelLength" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Centimeter") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.BMI')" prop="bmi">
                                        <Input name="bmi" v-model="camel.anthropometric.bmi" :value="camel.anthropometric.bmi" 
                                            :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                            :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.KilogramPerSquareMeter") }}</span>
                                    </FormItem>
                                </Col>
                            </Row>
                            <Row>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.FatRatioCoefficient')" prop="fatRatioCoefficient">
                                        <Input name="fatRatioCoefficient" v-model="camel.anthropometric.fatRatioCoefficient" 
                                            :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                            :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.MuscleWeight')" prop="muscleWeight">
                                        <Input name="muscleWeight" v-model="camel.anthropometric.muscleWeight" 
                                            :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                            :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                    </FormItem>
                                </Col>
                            </Row>
                            <Row>
                                <!--<BarChart :chartData="chartAnthropometric" :chartOptions="chartOptions" />-->
                                <monthly-income :chartData="chartAnthropometric" :chartOptions="chartOptions" />
                            </Row>
                        </TabPane>
                        <TabPane :label="L('Pages.Camels.Details')" name="detail">
                            <Col span="11">
                                <FormItem :label="L('Pages.Camels.Description')" prop="description">
                                    <textarea rows="5" style="width:100%;" class="ivu-input ivu-input-default" name="description" v-model="camel.description" disabled></textarea>
                                </FormItem>
                            </Col>
                            <Col span="11" offset="1">
                                <video :src="url" v-if="url" height="200" controls></video> <br />
                            </Col>
                        </TabPane>
                        <TabPane :label="L('Pages.Camels.MechanicalMeasurements')" name="mechanical">
                            <Row>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.TotalWeight')" prop="totalWeight">
                                        <Input name="totalWeight" v-model="camel.mechanical.totalWeight" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.StrokeDistance')" prop="strokeDistance">
                                        <Input name="strokeDistance" v-model="camel.mechanical.strokeDistance" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.Meter") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.Work')" prop="work">
                                        <Input name="work" v-model="camel.mechanical.work" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.Joule") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.StrokTime')" prop="strokTime">
                                        <Input name="strokTime" v-model="camel.mechanical.strokTime" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.GenralAbility')" prop="genralAbility">
                                        <Input name="genralAbility" v-model="camel.mechanical.genralAbility" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.JoulePerSecond") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.Velocity')" prop="velocity">
                                        <Input name="velocity" v-model="camel.mechanical.velocity" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.Gravity')" prop="gravity">
                                        <Input name="gravity" v-model="camel.mechanical.gravity" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.MeterPerSquareSecond") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.Mass')" prop="mass">
                                        <Input name="mass" v-model="camel.mechanical.mass" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                    <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                    </FormItem>
                                </Col>
                            </Row>
                            <Row>
                                <monthly-income :chartData="chartMechanical" :chartOptions="chartOptions" />
                            </Row>
                        </TabPane>
                        <TabPane :label="L('Pages.Camels.CausalVariables')" name="causal">
                            <Row>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.Mass')" prop="mass">
                                        <Input name="mass" v-model="camel.causal.mass" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Kilogram") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.Velocity')" prop="velocity">
                                        <Input name="velocity" v-model="camel.causal.velocity" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.MotionEnergy')" prop="kineticEnergy">
                                        <Input name="kineticEnergy" v-model="camel.causal.kineticEnergy" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Joule") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.VectorDistance')" prop="vectorDistance">
                                        <Input name="vectorDistance" v-model="camel.causal.vectorDistance" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Meter") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.VectorTime')" prop="vectorTime">
                                        <Input name="vectorTime" v-model="camel.causal.vectorTime" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.VectorVelocity')" prop="vectorVelocity">
                                        <Input name="vectorVelocity" v-model="camel.causal.vectorVelocity" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.LengthCycle')" prop="lengthCycle">
                                        <Input name="lengthCycle" v-model="camel.causal.lengthCycle" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Meter") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.FrequencyCycle')" prop="frequencyCycle">
                                        <Input name="frequencyCycle" v-model="camel.causal.frequencyCycle" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.FrequencyPerSecond") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.RateVelocity')" prop="rateVelocity">
                                        <Input name="rateVelocity" v-model="camel.causal.rateVelocity" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.MeterPerSecond") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.RightFrontFootSupportTime')" prop="rightFrontFootSupportTime">
                                        <Input name="rightFrontFootSupportTime" v-model="camel.causal.rightFrontFootSupportTime" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.LeftFrontFootSupportTime')" prop="leftFrontFootSupportTime">
                                        <Input name="leftFrontFootSupportTime" v-model="camel.causal.leftFrontFootSupportTime" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.RightFootSupportTime')" prop="rightFootSupportTime">
                                        <Input name="rightFootSupportTime" v-model="camel.causal.rightFootSupportTime" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7">
                                    <FormItem :label="L('Pages.Camels.LeftFootSupportTime')" prop="leftFootSupportTime">
                                        <Input name="leftFootSupportTime" v-model="camel.causal.leftFootSupportTime" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                    </FormItem>
                                </Col>
                                <Col span="7" offset="1">
                                    <FormItem :label="L('Pages.Camels.TotalStepCycleTime')" prop="totalStepCycleTime">
                                        <Input name="totalStepCycleTime" v-model="camel.causal.totalStepCycleTime" 
                                        :formatter="value => `${value}`.replace(/\B(?=(\d{3})+(?!\d))/g, ',')"
                                        :parser="value => value.replace(/\$\s?|(,*)/g, '')" disabled></Input>
                                        <span class="measurements">{{ L("Pages.Measurements.Second") }}</span>
                                    </FormItem>
                                </Col>
                            </Row>
                            <Row>
                                <monthly-income :chartData="chartCausal" :chartOptions="chartOptions" />
                            </Row>
                        </TabPane>
                    </Tabs>
                </Form>
                <div slot="footer">
                    <router-link class="ivu-btn ivu-btn-default" to="/admin/manage/camels">{{L('Cancel')}}</router-link>
                </div>
            </div>
        </Card>
    </div>
</template>
<style lang="less">
    @import '../../../styles/camels.less';
</style>
<script lang="ts">
    import { Component, Vue,Inject, Prop,Watch } from 'vue-property-decorator';
    import AbpBase from '../../../lib/abpbase';
    import appconst from '../../../lib/appconst';
    import Camel from '@/store/entities/camel';
    import AnthropometricMeasurement from '@/store/entities/anthropometric';
    import MechanicalMeasurement from '@/store/entities/mechanical';
    import CausalVariable from '@/store/entities/causal';
    //import BarChart from '../../../components/bar-chart.vue';
    import MonthlyIncome from '../../../components/MonthlyIncome.vue'

    @Component({
        components:{ MonthlyIncome }
    })
    export default class CamelDetails extends AbpBase{
        
        camel:Camel=new Camel();
        url: string = "";
        chartOptions: any;
        chartAnthropometric: any;
        chartMechanical: any;
        chartCausal: any;

        async created(){
            this.camel.anthropometric = new AnthropometricMeasurement();
            this.camel.mechanical = new MechanicalMeasurement();
            this.camel.causal = new CausalVariable();
            this.getData();
        }
        
        async getData(){
            debugger;
            this.camel = await this.$store.dispatch({
                        type:'camel/get',
                        id: this.$route.params.id
                    });
            debugger;
            if (this.camel.video) {
                const baseUrl = appconst.remoteServiceBaseUrl + '/Resources/UploadFiles/';
                this.url = baseUrl + this.camel.video;
            }
            if(this.camel.anthropometric == null){
                this.camel.anthropometric = new AnthropometricMeasurement();
            }
            if(this.camel.mechanical == null){
                this.camel.mechanical = new MechanicalMeasurement();
            }
            if(this.camel.causal == null){
                this.camel.causal = new CausalVariable();
            }
            this.$forceUpdate();
            
            this.chartOptions = {
                responsive: true,
                maintainAspectRatio: false
            };
            this.chartAnthropometric = {
                labels: [
                this.L('Pages.Camels.ShoulderHeight'),
                this.L('Pages.Camels.ChestWidth'),
                this.L('Pages.Camels.HumpGirth'),
                this.L('Pages.Camels.LiveWeight'),
                this.L('Pages.Camels.CamelLength'),
                this.L('Pages.Camels.BMI'),
                this.L('Pages.Camels.FatRatioCoefficient'),
                this.L('Pages.Camels.MuscleWeight')
                ],
                datasets: [
                {
                    label: this.L('Pages.Camels.AnthropometricMeasurements'),
                    backgroundColor: '#f87979',
                    data: [this.camel.anthropometric.shoulderHeight, this.camel.anthropometric.chestWidth, 
                    this.camel.anthropometric.humpGirth, this.camel.anthropometric.liveWeight, 
                    this.camel.anthropometric.camelLength, this.camel.anthropometric.bmi, 
                    this.camel.anthropometric.fatRatioCoefficient/10, this.camel.anthropometric.muscleWeight*-1/10000]
                }
                ]
            };
            this.chartMechanical = {
                labels: [
                this.L('Pages.Camels.TotalWeight'),
                this.L('Pages.Camels.StrokeDistance'),
                this.L('Pages.Camels.Work'),
                this.L('Pages.Camels.StrokTime'),
                this.L('Pages.Camels.GenralAbility'),
                this.L('Pages.Camels.Velocity'),
                this.L('Pages.Camels.Gravity'),
                this.L('Pages.Camels.Mass')
                ],
                datasets: [
                {
                    label: this.L('Pages.Camels.MechanicalMeasurements'),
                    backgroundColor: '#f87979',
                    data: [this.camel.mechanical.totalWeight, this.camel.mechanical.strokeDistance, 
                    this.camel.mechanical.work, this.camel.mechanical.strokTime, 
                    this.camel.mechanical.genralAbility, this.camel.mechanical.velocity/60, 
                    this.camel.mechanical.gravity, this.camel.mechanical.mass]
                }
                ]
            };
            this.chartCausal = {
                labels: [
                this.L('Pages.Camels.Mass'),
                this.L('Pages.Camels.Velocity'),
                this.L('Pages.Camels.MotionEnergy'),
                this.L('Pages.Camels.VectorDistance'),
                this.L('Pages.Camels.VectorTime'),
                this.L('Pages.Camels.VectorVelocity'),
                this.L('Pages.Camels.LengthCycle'),
                this.L('Pages.Camels.FrequencyCycle'),
                this.L('Pages.Camels.RateVelocity'),
                this.L('Pages.Camels.RightFrontFootSupportTime'),
                this.L('Pages.Camels.LeftFrontFootSupportTime'),
                this.L('Pages.Camels.RightFootSupportTime'),
                this.L('Pages.Camels.LeftFootSupportTime'),
                this.L('Pages.Camels.TotalStepCycleTime')
                ],
                datasets: [
                {
                    label: this.L('Pages.Camels.CausalVariables'),
                    backgroundColor: '#f87979',
                    data: [this.camel.causal.mass, this.camel.causal.velocity, 
                    this.camel.causal.kineticEnergy, this.camel.causal.vectorDistance, 
                    this.camel.causal.vectorTime, this.camel.causal.vectorVelocity, 
                    this.camel.causal.lengthCycle, this.camel.causal.frequencyCycle, 
                    this.camel.causal.rateVelocity, this.camel.causal.rightFrontFootSupportTime, 
                    this.camel.causal.leftFrontFootSupportTime, this.camel.causal.rightFootSupportTime, 
                    this.camel.causal.leftFootSupportTime, this.camel.causal.totalStepCycleTime]
                }
                ]
            };

        }
    }
    
</script>