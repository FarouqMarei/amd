import { CommonModule } from '@angular/common';
import { AutosComponent } from './../../pages/autos/autos.component';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AdminLayoutRoutes } from './admin-layout.routing';

import { DashboardComponent }       from '../../pages/dashboard/dashboard.component';
import { UserComponent }            from '../../pages/user/user.component';
import { TableComponent }           from '../../pages/table/table.component';
import { TypographyComponent }      from '../../pages/typography/typography.component';
import { MapsComponent }            from '../../pages/maps/maps.component';
import { NotificationsComponent }   from '../../pages/notifications/notifications.component';
import { TableModule } from 'primeng/table';
import { CheckboxModule } from 'primeng/checkbox';
import { FormsModule } from '@angular/forms';
import { RippleModule } from 'primeng/ripple';
import { ButtonModule } from 'primeng/button';
import { DialogModule } from 'primeng/dialog';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ConfirmationService } from 'primeng/api';

@NgModule({
  imports: [
    RouterModule.forChild(AdminLayoutRoutes),
    TableModule,
    CommonModule,
    CheckboxModule,
    FormsModule,
    RippleModule,
    ButtonModule,
    DialogModule,
    ConfirmDialogModule
  ],
  declarations: [
    DashboardComponent,
    UserComponent,
    TableComponent,
    TypographyComponent,
    MapsComponent,
    NotificationsComponent,
    AutosComponent
  ],
  exports: [
  ],
  providers: [
    ConfirmationService
  ]
})

export class AdminLayoutModule {}
