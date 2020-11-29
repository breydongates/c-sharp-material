<template>
  <div id="app" class="main">
    <product-info v-bind:productId="productId" />
    <review-list v-bind:productId="productId" />
  </div>
</template>

<script>
import ReviewList from "@/components/ReviewList.vue";
import ProductInfo from '../components/ProductInfo.vue';

export default {
  name: "product-detail",
  components: {
    ReviewList,
    ProductInfo
  },
  data() {
      return {
          productId: 0,
      }
  },
  computed: {
    product() {
      return this.$store.state.products.find(p => p.id == this.productId);
    }
  },
  /*
  created is a Vue Lifecycle Hook which are explained in greater
  detail in the JavaScript Web Services topic.
  For now, it should be enough to understand the code inside the
  method is executed each time a new instance of ProductDetail
  is created.
  */
  created() {
    this.productId = this.$route.params.id;
  }
};
</script>
