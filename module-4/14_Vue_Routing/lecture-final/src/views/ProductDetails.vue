<template>
  <div>
    <product-info v-bind:productId="productId" />
    <review-list v-bind:productId="productId" />
  </div>
</template>

<script>
import ReviewList from "@/components/ReviewList.vue";
import ProductInfo from '@/components/ProductInfo.vue';

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
  created() {
    console.debug('My current route is', this.$route);
    this.productId = Number.parseInt(this.$route.params.productId);

    const id = this.$route.params.productId;
    const product = this.$store.state.products.find(p => p.id == id);
    
    console.debug('My product is', product);
  },
  computed: {
    prodId() {
      return this.$route.params.productId;
    }
  }
};
</script>
