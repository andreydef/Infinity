import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

import { ContactInfo } from '../../models/Contact_info';
import { ContactMe } from '../../models/Contact_me';
import { ContactService } from '../../services/contact.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css'],
  providers: [ ContactService ]
})
export class ContactComponent implements OnInit {
  contacts_info: ContactInfo[];
  contacts_me: ContactMe[];

  constructor(public contactService: ContactService) { }

  ngOnInit() {
    this.loadContactsInfo();
    this.loadContactsMe();
  }

  loadContactsInfo() {
    this.contactService.getContactsInfo()
      .subscribe((data: ContactInfo[]) => this.contacts_info = data);
  }

  loadContactsMe() {
    this.contactService.getContactsMe()
      .subscribe((data: ContactMe[]) => this.contacts_me = data);
  }

  insertRecord(form: NgForm) {
    this.contactService.postContact().subscribe(
      res => {
        this.resetForm(form);
        confirm('You question successfully send to admin');
      }
    );
  }

  onSubmit(form: NgForm) {
    if (this.contactService.formData.id === 0) {
      this.insertRecord(form);
    }
  }

  resetForm(form?: NgForm) {
    if (form != null) {
      form.form.reset();
    }
    this.contactService.formData = {
      id: 0,
      name: '',
      email: '',
      subject: '',
      message: ''
    };
  }
}
