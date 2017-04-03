import { Injectable, Inject, Optional } from '@angular/core';
import { Http, RequestOptions, Headers, Response } from '@angular/http';
import { Observable } from 'rxjs';
import { API_BASE_URL } from '@shared/service-proxies/service-proxies';


@Injectable()
export class EventServiceProxy {
    private http: Http = null; 
    private baseUrl: string = undefined; 
    protected jsonParseReviver: (key: string, value: any) => any = undefined;

    constructor(@Inject(Http) http: Http, @Optional() @Inject(API_BASE_URL) baseUrl?: string) {
        this.http = http; 
        this.baseUrl = baseUrl ? baseUrl : ""; 
    }

    createEvent(input: any): Observable<string> {
        let url_ = this.baseUrl + "/api/services/app/EventService/CreateEvent";
        
        return this.http.request(url_, {
            body: input,
            method: "post",
            headers: new Headers({
                "Content-Type": "application/json; charset=UTF-8", 
				"Accept": "application/json; charset=UTF-8"
            })
        }).map((response) => {
        }).catch((response: any, caught: any) => {
            console.log(response);
            console.log("caught: " + caught)
            return null;
        });
    }
}