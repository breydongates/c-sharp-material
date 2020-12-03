import axios from 'axios';

const http = axios.create({
  baseURL: "http://localhost:3000"
});

export default {

  get(id) {
    return http.get(`/messages/${id}`);
  },

  createMessage(newMessage){
    return http.post('/messages/', newMessage);
  },

  updateMessage(id, editMessage){
    return http.put('/messages/' + id, editMessage);
  },

  deleteMessage(id) {
    return http.delete('/messages/' + id);
  },


}
