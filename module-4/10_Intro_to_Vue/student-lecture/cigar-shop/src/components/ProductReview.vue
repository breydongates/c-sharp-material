<template>
    <article>
        <h2>Product Review for {{productName}}</h2>
        <p> {{description}} </p>

        <section>
            <h3>Filter Reviews</h3>
            <div class="field">
                <label for="txtSearch"> Text Search</label>
                <input type="text" id="txtSearch" v-model="search.textSearch">
            </div>
            <div class="field">
                <label for="txtMinScore">Minimum Score</label>
                <input type="number" min="0" max="5" id="txtMinScore" v-model.number="search.minScore">
            </div>
        </section>
        <section class ='review' v-for="review of filteredReviews" v-bind:key="review.id"
                v-bind:class="{fivestar: review.rating === 5, onestar: review.rating === 1}">

            <h4> {{review.reviewer}} </h4>
            <div class="rating">
                <img v-bind:src="imagePath" height="32px" v-for="n of review.rating" v-bind:key="n" />
            </div>
            <p> {{review.text}} </p>        
        </section>

        <p>Average Rating: {{averageRating}}</p>
    </article>
</template>

<script>
export default {
    name: 'ProductReview', 
    computed: {
        filteredReviews(){
            let currentReviews = this.reviews;

            if(this.search.textSearch){
                currentReviews = currentReviews.filter(r => r.text.includes(this.search.textSearch));
            }

            if(this.search.minScore){
                currentReviews = currentReviews.filter(r => r.rating >= this.search.minScore);
            }

            return currentReviews;
        },
        averageRating(){
            let total = 0;

            this.filteredReviews.forEach(review => total += review.rating);
                
            return total / this.filteredReviews.length;
        },
    },
    data(){
        return {
            search: {
                textSearch: '',
                minScore: 0,
            },
            imagePath: 'logo.png',
            productName: 'Cigar party for Dummies',
            description: 'Smoking for your health',
            reviews: [
                {
                    id: 1,
                    reviewer: 'Big Dummy',
                    rating: 3,
                    text: 'Yummy yummy'
                },
                {
                    id: 2,
                    reviewer: 'Tiny Dummy',
                    rating: 5,
                    text: 'Yummy yummy, but smaller'
                },
                {
                    id: 3,
                    reviewer: 'Joe Cool',
                    rating: 2,
                    text: 'Its no Camel'
                }
            ]
        }
    }
}
</script>

<style scoped>

article, section {
    padding: 0.5rem;
    background: brown;
}

.review {
    text-align: left;
}

.rating, h4{
    display: inline;
}

.field{
    margin: 0.5rem;
}

input {
    margin-left: 0.5rem;
}

p {
    color:pink;
}
.fivestar {
    color: yellow;
}
.onestar {
    color: silver;
}
</style>