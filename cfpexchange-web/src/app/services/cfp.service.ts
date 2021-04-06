import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

import { Cfp } from '../models/cfp';

const serviceBaseUrl: string = environment.serviceBaseUrl;

@Injectable({
  providedIn: 'root'
})
export class CfpService {

  constructor(private httpClient: HttpClient) { 
  }

  public getCfps(): Observable<Cfp[]> {
    return this.httpClient.get<Cfp[]>(`${serviceBaseUrl}cfps`);
  }
}
