import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
@Injectable({
  providedIn: 'root'
})
export class ProductListService {

constructor(private http:HttpClient) { }

GetTenExpensiveProducts():any{
  return this.http.get<any>('https://localhost:7000/api/Products')

}
}
