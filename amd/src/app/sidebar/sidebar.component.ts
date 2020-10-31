import { Component, OnInit } from '@angular/core';


export interface RouteInfo {
    path: string;
    title: string;
    icon: string;
    class: string;
}

export const ROUTES: RouteInfo[] = [
    { path: '/dashboard',     title: 'Dashboard',         icon: 'fa fa-home',       class: '' },
    { path: '/autos',         title: 'Autos',             icon: 'fa fa-car',    class: '' },
    { path: '/maps',          title: 'Maps',              icon: 'fa fa-globe',      class: '' },
    { path: '/notifications', title: 'Notifications',     icon: 'fa fa-bell',    class: '' },
    { path: '/user',          title: 'User Profile',      icon: 'fa fa-user',  class: '' },
    { path: '/table',         title: 'Table List',        icon: 'fa fa-table',    class: '' },
    { path: '/typography',    title: 'Typography',        icon: 'nc-icon nc-caps-small', class: '' }
];

@Component({
    moduleId: module.id,
    selector: 'sidebar-cmp',
    templateUrl: 'sidebar.component.html',
})

export class SidebarComponent implements OnInit {
    public menuItems: any[];
    ngOnInit() {
        this.menuItems = ROUTES.filter(menuItem => menuItem);
    }
}
