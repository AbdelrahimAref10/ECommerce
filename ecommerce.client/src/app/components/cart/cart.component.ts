import { Component } from '@angular/core';
import { RouterLink, RouterModule } from '@angular/router';
import { CartService } from '../../core/services/cart.service';
import { ProductsVm } from '../../core/services/clientAPI';

@Component({
  selector: 'app-cart',
  standalone: true,
  imports: [RouterLink, RouterModule],
  providers:[CartService],
  templateUrl: './cart.component.html',
  styleUrl: './cart.component.css'
})
export class CartComponent {
  constructor(private cartService: CartService){}

  get cartProducts(){
    debugger;
    return this.cartService.cartProducts();
  }
  remove(product: ProductsVm){
    this.cartService.remove(product);
  }
}
