import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-package',
  templateUrl: './package.component.html',
  styleUrls: ['./package.component.css']
})
export class PackageComponent {
  title = 'AngularHttpRequest';

  constructor(private http: HttpClient) {

  }

  onProductCreate(products: {
    "name": string,
    "code": string,
    "Brand": string,
    "unitPrice": string
  }) {
    console.log(products);
    this.http.post('https://localhost:7054/api/Item/add', products).subscribe((res) => {
      console.log(res);
    })
  }
}
