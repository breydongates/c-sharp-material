<template>
  <div class="card">
      <h2>{{book.title}}</h2>
    
    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    
    <h3>{{book.author}}</h3>
    <button class="read" v-on:click="markRead" >
        <span class="mark-read" v-if="book.read == true"> Mark Unread</span>
        <span class="mark-unread" v-else-if="book.read == false">Mark Read</span>
    </button>
  </div>
</template>

<script>
export default {
    name: 'book-card',
    props: {
        book: Object,
    },
    methods: {
        markRead(){
            this.$store.commit('MARK_READ', this.book);
        },
    }
}
</script>

<style>
.card {
    border: 2px solid black;
    border-radius: 10px;
    width: 250px;
    height: 550px;
    margin: 20px;
}

.card.read {
    background-color: lightgray;
}

.card .book-title {
    font-size: 1.5rem;
}

.card .book-author {
    font-size: 1rem;
}
</style>