import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-product',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './add-product.component.html',
  styleUrl: './add-product.component.css'
})
export class AddProductComponent {
  ProductForm!:FormGroup;
  productData:any;
  constructor(private fb: FormBuilder){

  }

  ngOnInit(){
    this.ProductForm = this.fb.group({
      ProdName:['', Validators.required],
      prodDecription:[[]],
      catName:['', Validators.required],
      price:['', Validators.required],
    })
  }

  onSubmit(data: any){
    this.productData = data;
    console.log("this data: ",data);
  }
  
}
