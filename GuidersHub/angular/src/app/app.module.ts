﻿import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule, JsonpModule } from '@angular/http';

import { ModalModule } from 'ng2-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { AbpModule, ABP_HTTP_PROVIDER } from '@abp/abp.module';

import { ServiceProxyModule } from '@shared/service-proxies/service-proxy.module';
import { SharedModule } from '@shared/shared.module';

import { API_BASE_URL } from '@shared/service-proxies/service-proxies';
import { AppConsts } from '@shared/AppConsts';

import { HomeComponent } from '@app/home/home.component';
import { AboutComponent } from '@app/about/about.component';
import { UsersComponent } from '@app/users/users.component';
import { CreateUserModalComponent } from '@app/users/create-user-modal.component';
import { TenantsComponent } from '@app/tenants/tenants.component';
import { CreateTenantModalComponent } from '@app/tenants/create-tenant-modal.component';
import { EventListComponent} from '@app/event/event-list/event.list.component';
import { CreateEventComponent} from '@app/event/create-event/event.component';
import { EventDetailsComponent} from '@app/event/event-details/event.details.component';

import { EventServiceProxy } from '@app/event/services/event.service';


@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        AboutComponent,
        UsersComponent,
        CreateUserModalComponent,
        TenantsComponent,
        CreateTenantModalComponent,
        EventListComponent,
        CreateEventComponent, 
        EventDetailsComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        HttpModule,
        JsonpModule,
        ModalModule.forRoot(),
        AbpModule,
        AppRoutingModule,
        ServiceProxyModule,
        SharedModule
    ],
    providers: [
        EventServiceProxy
    ]
})
export class AppModule { }