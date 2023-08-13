declare global {
    interface RouterMeta {
        title: string;
    }
    interface Router {
        path: string;
        name: string;
        icon?: string;
        permission?: string;
        meta?: RouterMeta;
        component: any;
        children?: Array<Router>;
    }
    interface System {
        import(request: string): Promise<any>
    }
    var System: System
}
import login from '../views/login.vue'
import home from '../views/home/home.vue'
import main from '../views/main.vue'
import dashboard from '../views/dashboard.vue'

export const locking = {
    path: '/locking',
    name: 'locking',
    component: () => import('../components/lockscreen/components/locking-page.vue')
};
export const loginRouter: Router = {
    path: '/login',
    name: 'login',
    meta: {
        title: 'LogIn'
    },
    component: () => import('../views/login.vue')
};
export const dashboardRouter: Router = {
    path: '/',
    name: 'dashboard',
    meta: {
        title: 'dashboard'
    },
    component: () => import('../views/dashboard.vue')
};

export const otherRouters: Router = {
    path: '/admin',
    name: 'admin',
    permission: '',
    meta: { title: 'ManageMenu' },
    component: main,
    children: [
        { path: 'home', meta: { title: 'HomePage' }, name: 'home', component: () => import('../views/home/home.vue') },
        { path: 'camel/:id', permission: 'Pages.Camels', meta: { title: 'Camel' }, name: 'camel',component: () => import('../views/setting/camel/camel-details.vue')}
    ]
}
export const appRouters: Array<Router> = [{
    path: '/admin/manage',
    name: 'setting',
    permission: '',
    meta: { title: 'ManageMenu' },
    icon: '&#xe68a;',
    component: main,
    children: [
        { path: 'user', permission: 'Pages.Users', meta: { title: 'Users' }, name: 'user', component: () => import('../views/setting/user/user.vue') },
        { path: 'role', permission: 'Pages.Roles', meta: { title: 'Roles' }, name: 'role', component: () => import('../views/setting/role/role.vue') },
        { path: 'tenant', permission: 'Pages.Tenants', meta: { title: 'Tenants' }, name: 'tenant', component: () => import('../views/setting/tenant/tenant.vue') },
        { path: 'camels', permission: 'Pages.Camels', meta: { title: 'Camels' }, name: 'camels', component: () => import('../views/setting/camel/camel.vue') }
    ]
}]
export const routers = [
    loginRouter,
    dashboardRouter,
    locking,
    ...appRouters,
    otherRouters
];
