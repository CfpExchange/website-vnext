import { Component, OnInit } from '@angular/core';

import { Contact } from 'src/app/models/contact';
import { MailService } from 'src/app/services/mail.service';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.scss']
})
export class ContactComponent implements OnInit {

  public Contact: Contact = new Contact();

  constructor(private mailService: MailService) { }

  ngOnInit(): void {
  }

  public sendContact(): void {
    this.mailService.sendContact(this.Contact).subscribe((data) => {
      this.Contact = new Contact();
    }, (err) => {
    });
  }
}
