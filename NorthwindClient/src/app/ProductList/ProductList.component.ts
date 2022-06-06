import { Component, OnInit } from '@angular/core';
import { ProductListService } from './ProductList.service';
import {Product} from './ProductModel'
@Component({
  selector: 'app-ProductList',
  templateUrl: './ProductList.component.html',
  styleUrls: ['./ProductList.component.css']
})
export class ProductListComponent implements OnInit {
  public loadedProducts: Product[]=[];
  constructor(private readonly service:ProductListService) { }

  ngOnInit() {
    this.LoadTenExpensiveProducts()
  }
private LoadTenExpensiveProducts():void{
  this.service.GetTenExpensiveProducts().subscribe((products:Product[])=>{
     this.loadedProducts=products;
console.log(this.loadedProducts)
  })
}
}
