import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class AboutService {

  private url = 'api/about';

  constructor(private http: HttpClient) { }

  getAbouts() {
    return this.http.get(this.url);
  }
}
