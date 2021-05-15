import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Contacts } from '../models/Contacts';

@Injectable()
export class ContactService {
  formData: Contacts = {
    id: 0,
    name: null,
    email: null,
    subject: null,
    message: null
  };

  private contacts = 'api/contacts';
  private contact_me = 'api/contact-me';
  private contact_info = 'api/contact-info';

  constructor(private http: HttpClient) { }

  getContactsInfo() {
    return this.http.get(this.contact_info);
  }

  getContactsMe() {
    return this.http.get(this.contact_me);
  }

  postContact() {
    return this.http.post(this.contacts, this.formData);
  }
}
