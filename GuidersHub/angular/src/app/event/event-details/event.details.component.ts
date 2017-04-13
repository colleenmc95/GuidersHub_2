import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
    templateUrl: './event.details.component.html',
    animations: [appModuleAnimation()],
    styleUrls: ['./event.details.component.less']
})
export class EventDetailsComponent extends AppComponentBase {

    constructor(injector: Injector) {
        super(injector);
    }
}