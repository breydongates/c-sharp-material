<template>
  <div>
    <h1>{{ product.name }}</h1>
    <p class="description">{{ product.description }}</p>
    <nav>
        <!-- <a href="#TODO">Back to Products</a>
        <a href="#TODO">Add Review</a> -->
        <router-link v-bind:to="{name: 'home'}">Back to Products</router-link>
        <router-link v-bind:to="{name: 'add-review', params: {id: product.id}}">
          Add Review
        </router-link>
    </nav>
    <div class="well-display">
      <average-summary v-bind:productId="productId" />
      <star-summary :productId="productId" rating="1" />
      <star-summary v-bind:productId="productId" rating="2" />
      <star-summary v-bind:productId="productId" rating="3" />
      <star-summary v-bind:productId="productId" rating="4" />
      <star-summary v-bind:productId="productId" rating="5" />
    </div>
  </div>
</template>

<script>
import StarSummary from './StarSummary';
import AverageSummary from './AverageSummary';

export default {
    components: {
        StarSummary,
        AverageSummary,
    },
    props: {
        productId: Number,
    },
    computed: {
        product() {
            return this.$store.state.products.find(p => p.id === this.productId);
        }
    }
}
</script>