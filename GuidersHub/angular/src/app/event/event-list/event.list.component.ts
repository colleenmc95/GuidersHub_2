import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';

@Component({
    templateUrl: './event.list.component.html',
    animations: [appModuleAnimation()],
    styleUrls: ['./event.list.component.less']
})
export class EventListComponent extends AppComponentBase {

    constructor(
        injector: Injector
    ) {
        super(injector);
    }
}