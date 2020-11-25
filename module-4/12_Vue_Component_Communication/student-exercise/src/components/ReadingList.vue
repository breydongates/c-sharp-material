<template>
  <div class="book-container">
    <book-card v-for="b in showBooks"
              v-bind:key="b.isbn" 
              v-bind:book="b" />
               
  </div>
</template>

<script>
import BookCard from './BookCard.vue';

export default {
    name: 'reading-list',
    components:{
        BookCard
        },

   computed: {
      showBooks() {
        return this.$store.state.books;
      },
   },
   strict: true
}
</script>

<style>
.book-container {
    display:flex;
    justify-content: space-evenly;
    flex-wrap: wrap;
}
</style>