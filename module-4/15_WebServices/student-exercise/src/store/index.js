import Vue from 'vue'
import Vuex from 'vuex'

Vue.use(Vuex)

export default new Vuex.Store({
  state: {
    topics: [],
    activeTopic: {
      id: 0,
      title: '',
      messages: []
    },
    activeMessage: {
      id: null,
      topicId: null,
      title: '',
      messageText: ''
    }
  },
  mutations: {
    SET_TOPICS(state, data) {
      state.topics = data;
    },
    SET_ACTIVE_TOPIC(state, data) {
      state.activeTopic = data;
    },
    DELETE_MESSAGE(state, id) {
      state.activeTopic.messages.splice(
        state.activeTopic.messages.findIndex(message => message.id === id),
        1
      )
    },
    CREATE_MESSAGE(state, payload){
      state.activeTopic.messages.push(payload)
    },

    SET_ACTIVE_MESSAGE(state, data) {
      state.activeMessage = data;
    },
    ADD_TOPIC(state, payload){
      state.topics.push(payload)
    },
    UPDATE_TOPIC(state, payload){
      const index = state.topics.findIndex(t => t.id === payload.id);
      if(index >= 0){
        state.topics.splice(index, 1, payload);
      }
    },
    UPDATE_MESSAGE(state, payload){
      const index = state.activeTopic.messages.findIndex(m => m.id === payload.id);
      if(index >= 0){
        state.activeTopic.messages.splice(index, 1, payload);
      }
    }
  },
  actions: {
  },
  modules: {
  }
})
