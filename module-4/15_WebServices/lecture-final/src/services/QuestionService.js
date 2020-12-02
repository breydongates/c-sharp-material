import axios from 'axios';

// This is a path to the application we'll be communicating with. It can be any server
// that can handle REST requests.
const myServerUrl = 'https://sallythesquirrelservice.azurewebsites.net';

// Create our Axios instance used to communicate with the server and set the baseURL
const http = axios.create({ baseURL: myServerUrl});

export default {
    getAllQuestions() {
        return http.get('/questions'); // I return a promise of question data to come
    },
    createNewQuestion(newQuestion) {
        return http.post('/questions', newQuestion);
    },
    editQuestion(id, updatedQuestion) {
        return http.put('/questions/' + id, updatedQuestion);
    },
    deleteQuestion(id) {
        return http.delete(`/questions/${id}`);
    }
}