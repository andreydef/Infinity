import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable()
export class LinksService {

  private url = 'api/links';

  constructor(private http: HttpClient) { }

  getLinks() {
    return this.http.get(this.url);
  }
}
