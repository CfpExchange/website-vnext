import { Component, OnInit } from '@angular/core';
import { Contact } from 'src/app/models/contact';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit {

  public Contact: Contact = new Contact();

  constructor() { }

  ngOnInit(): void {
  }

  public sendContact(): void {
    console.log(this.Contact);
  }
}
