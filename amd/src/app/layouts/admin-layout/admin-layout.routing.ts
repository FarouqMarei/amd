import { AutosComponent } from './../../pages/autos/autos.component';
import { AuthService } from './../../services/auth.service';
import { Routes } from '@angular/router';

import { DashboardComponent } from '../../pages/dashboard/dashboard.component';
import { UserComponent } from '../../pages/user/user.component';
import { TableComponent } from '../../pages/table/table.component';
import { TypographyComponent } from '../../pages/typography/typography.component';
import { MapsComponent } from '../../pages/maps/maps.component';
import { NotificationsComponent } from '../../pages/notifications/notifications.component';

export const AdminLayoutRoutes: Routes = [
    { path: 'dashboard',      component: DashboardComponent, canActivate: [AuthService] },
    { path: 'user',           component: UserComponent, canActivate: [AuthService] },
    { path: 'table',          component: TableComponent, canActivate: [AuthService] },
    { path: 'typography',     component: TypographyComponent, canActivate: [AuthService] },
    { path: 'autos',          component: AutosComponent, canActivate: [AuthService] },
    { path: 'maps',           component: MapsComponent, canActivate: [AuthService] },
    { path: 'notifications',  component: NotificationsComponent, canActivate: [AuthService] }
];
