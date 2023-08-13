import ajax from '../../lib/ajax';
import axios from 'axios'
import appconst from '../../lib/appconst'

const upload={
    namespaced: true,
    state:{
        
    },
    actions:{
        async upload(state:any,file:any){
debugger;
            const formData = new FormData();
            formData.append('file', file);
            const headers = { 'Content-Type': 'multipart/form-data' };
            return axios.post(appconst.remoteServiceBaseUrl+'/api/upload/upload', formData, { headers }).then((res) => {
                debugger;
                return res;
            });
        }
    }
}
export default upload;