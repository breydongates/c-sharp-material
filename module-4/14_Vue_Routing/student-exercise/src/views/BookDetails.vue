<template>
  <div class="card"> 
  <nav>
      <router-link v-bind:to="{name: 'home'}"> Home    </router-link>
      <router-link v-bind:to="{name: 'myBooks'}"> My Books </router-link>
    </nav>
    <h2 class="book-title"> {{ book.title }}
        
        </h2>

    <img v-if="book.isbn" v-bind:src="'http://covers.openlibrary.org/b/isbn/' + book.isbn + '-M.jpg'" />
    <h3 class="book-author">{{ book.author }}</h3>
</div>
</template>

<script>
export default {
    name: 'book-details',
    
        data(){
        return {
            book: undefined,
            isbn: 0,
        }
    },
    created(){
        
        this.isbn = Number.parseInt(this.$route.params.isbn);

        const bookIsbn = this.$route.params.isbn;
        this.book = this.$store.state.books.find(b => b.isbn == bookIsbn);
        console.debug('My book is ', this.book);
    },



}
</script>

<style>

</style>