import { Injectable, signal } from '@angular/core';
import { ProductsVm } from './clientAPI';

@Injectable({
  providedIn: 'root'
})
export class CartService {

  constructor() { }
  cartProducts = signal<ProductsVm[]>([]);
  add(product: ProductsVm){
      this.cartProducts.update((oldProduct)=> [...oldProduct, product]);
      console.log(product);
  }
  remove(product: ProductsVm) {
      this.cartProducts.update(oldProduct => oldProduct.filter(p=> p!= product));
  }
}
