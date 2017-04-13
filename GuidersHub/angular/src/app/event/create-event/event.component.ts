import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

import { EventServiceProxy } from '../services/event.service';

@Component({
    templateUrl: './event.component.html',
    animations: [appModuleAnimation()],
    styleUrls: ['./event.component.less']
})
export class CreateEventComponent extends AppComponentBase {

    public event: Event = null;

    public name: string = "Test";

    constructor(injector: Injector, private eventService: EventServiceProxy) {
        super(injector);

    }

    submit() {
        console.log(this.name);
        this.name = "Testing"

        this.eventService.createEvent({
            "name": "string",
            "creationTime": "2017-03-31T16:34:34.182Z",
            "eventTime": "2017-03-31T16:34:34.183Z",
            "location": "string",
            "description": "string",
            "id": 0
        }).subscribe(result => console.log(result))
    }
}

export interface Event {
    name: string;
    description: string,
    location: string;
    date: Date
}