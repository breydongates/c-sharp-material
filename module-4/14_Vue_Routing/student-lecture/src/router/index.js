import Vue from 'vue'
import VueRouter from 'vue-router'
import Products from '@/views/Products';
import NotFound from '@/views/NotFound';
import About from '@/views/About';
import ProductDetails from '@/views/ProductDetails';
import AddReview from '@/views/AddReview';

Vue.use(VueRouter)

const routes = [
  {
    path: '/',
    name: 'products',
    component: Products,
  },
  {
    path: '/products/:id',
    name: 'product-details',
    component: ProductDetails,
  },
  {
    path: '/products/:id/new-review',
    name: 'add-review',
    component: AddReview,
  },
  {
    path: '/about',
    name: 'about',
    component: About,
  },
  {
    path: '*',
    name: 'not-found',
    component: NotFound,
  }
]

const router = new VueRouter({
  mode: 'history',
  base: process.env.BASE_URL,
  routes
})

export default router
