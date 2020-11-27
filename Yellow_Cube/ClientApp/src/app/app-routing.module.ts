// =============================
// Email: info@ebenmonney.com
// www.ebenmonney.com/templates
// =============================

import { NgModule } from '@angular/core';
import { Routes, RouterModule, DefaultUrlSerializer, UrlSerializer, UrlTree } from '@angular/router';

import { LoginComponent } from './components/login/login.component';
import { HomeComponent } from './components/home/home.component';
import { CustomersComponent } from './components/customers/customers.component';
import { ProductsComponent } from './components/products/products.component';
import { OrdersComponent } from './components/orders/orders.component';
import { SettingsComponent } from './components/settings/settings.component';
import { AboutComponent } from './components/about/about.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { AuthService } from './services/auth.service';
import { AuthGuard } from './services/auth-guard.service';
import { Utilities } from './services/utilities';
import { AuthenticatedLayoutComponent } from './components/authenticated-layout/authenticated-layout.component';
import { DriversComponent } from './components/drivers/drivers.component';
import { VehiclesComponent } from './components/vehicles/vehicles.component';
import { VehicleCategoriesComponent } from './components/vehicle-categories/vehicle-categories.component';
import { DriverLayoutComponent } from './components/driver-layout/driver-layout.component';
import { RegisterDriverComponent } from './components/register-driver/register-driver.component';



export class LowerCaseUrlSerializer extends DefaultUrlSerializer {
  parse(url: string): UrlTree {
    const possibleSeparators = /[?;#]/;
    const indexOfSeparator = url.search(possibleSeparators);
    let processedUrl: string;

    if (indexOfSeparator > -1) {
      const separator = url.charAt(indexOfSeparator);
      const urlParts = Utilities.splitInTwo(url, separator);
      urlParts.firstPart = urlParts.firstPart.toLowerCase();

      processedUrl = urlParts.firstPart + separator + urlParts.secondPart;
    } else {
      processedUrl = url.toLowerCase();
    }

    return super.parse(processedUrl);
  }
}


const routes: Routes = [

  { path: 'login', component: LoginComponent, data: { title: 'Login' } },
  { path: '', redirectTo: '/app', pathMatch: 'full' },
  {
    path: 'app', component: AuthenticatedLayoutComponent, canActivate: [AuthGuard], children: [
      { path: '', component: HomeComponent, canActivate: [AuthGuard], data: { title: 'Home' } },
      { path: 'drivers', component: DriversComponent, data: { title: 'Drivers' } },
      { path: 'vehicles', component: VehiclesComponent, data: { title: 'Vehicles' } },
      { path: 'vehicle-classes', component: VehicleCategoriesComponent, data: { title: 'Vehicle Classes' } },
      { path: 'trips', component: DriversComponent, data: { title: 'Trips' } },
      { path: 'settings', component: SettingsComponent, canActivate: [AuthGuard], data: { title: 'Settings' } },
      { path: 'about', component: AboutComponent, data: { title: 'About Us' } },

    ]
  },
  { path: 'driver', component:DriverLayoutComponent ,children:[
    { path: '', component: RegisterDriverComponent, canActivate: [AuthGuard], data: { title: 'Home' } },
  ] },
  { path: '**', component: NotFoundComponent, data: { title: 'Page Not Found' } }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  providers: [
    AuthService,
    AuthGuard,
    { provide: UrlSerializer, useClass: LowerCaseUrlSerializer }]
})
export class AppRoutingModule { }