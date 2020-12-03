import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  list() {
    return http.get('/topics');
  },

  get(id) {
    return http.get(`/topics/${id}`);
  },

  addTopic(newTopic) {
    return http.post('/topics', newTopic);
  },
  
  updateTopic(id, editTopic){
    return http.put('/topics/' + id, editTopic);
  },

  deleteTopic(id){
    return http.delete('/topics/' + id);
  },

}
