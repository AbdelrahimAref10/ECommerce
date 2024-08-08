import { Routes, provideRouter } from '@angular/router';
import { ProductsComponent } from './components/products/products.component';
import { CartComponent } from './components/cart/cart.component';
import { ProductDetailsComponent } from './components/product-details/product-details.component';
import { AddProductComponent } from './components/add-product/add-product.component';

export const routes: Routes = [
  { path: '', redirectTo: '/products', pathMatch: 'full' },
  {path:'products', component:ProductsComponent},
  {path:'cart', component:CartComponent},
  {path:'products/productDetails/:id', component:ProductDetailsComponent},
  {path:'addProduct', component:AddProductComponent},
];

export const appRouterProviders = [provideRouter(routes)];
