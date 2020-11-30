import Vue from 'vue'
import VueRouter from 'vue-router'
import Products from '@/views/Products.vue';
import About from '@/views/About.vue';
import NotFound from '@/views/NotFound.vue';
import ProductDetails from '@/views/ProductDetails.vue';
import NewReview from '@/views/NewReview.vue';

Vue.use(VueRouter)

const routes = [
  // Add a base route listing all products
  {
    path: '/',
    name: 'home',
    component: Products,
  },

  // Add an about route
  {
    path: '/about-this-organization',
    name: 'about-us',
    component: About
  },

  // Add a product details route
  {
    path: '/products/:productId', // products/4
    name: 'product-details',
    component: ProductDetails,
  },

  // Add an add review route
  {
    path: '/products/:id/new-review',
    name: 'add-review',
    component: NewReview,
  },

  // Add a not found route
  {
    path: '*',
    name: 'not-found',
    component: NotFound,
  },
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
