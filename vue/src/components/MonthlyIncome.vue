
<script>
import { Bar } from 'vue-chartjs'
 
export default {
  name: 'monthly-income',
  extends: Bar,
  props: ['chartData', 'chartOptions'],
  mounted () {
    debugger;
    setTimeout(() => {
        debugger;
        this.renderChart(this.chartData, this.chartOptions);
    }, 2000);
  }
}
</script>