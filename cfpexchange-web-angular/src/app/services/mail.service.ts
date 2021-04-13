import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';

import { environment } from 'src/environments/environment';
import { Contact } from '../models/contact';

const serviceBaseUrl: string = environment.serviceBaseUrl;

@Injectable({
  providedIn: 'root'
})
export class MailService {

  constructor(private httpClient: HttpClient) { }

  public sendContact(message: Contact): Observable<object> {
    return this.httpClient.post(`${serviceBaseUrl}contact`, message);
  }
}
