import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { AboutComponent } from './components/about/about.component';
import { PortfolioComponent } from './components/portfolio/portfolio.component';
import { ServicesComponent } from './components/services/services.component';
import { ContactComponent } from './components/contact/contact.component';
import { HeaderComponent } from './components/header/header.component';
import { TestimonialsComponent } from './components/testimonials/testimonials.component';
import { CalculatorComponent } from './components/calculator/calculator.component';

const appRoutes: Routes = [
  {
    path: '',
    component: HomeComponent,
    children: [
      { path: '', component: HeaderComponent },
      { path: 'about', component: AboutComponent },
      { path: 'portfolio', component: PortfolioComponent },
      { path: 'services', component: ServicesComponent },
      { path: 'contact', component: ContactComponent },
      { path: 'review', component: TestimonialsComponent }
    ],
    pathMatch: 'full'
  },

  // no layout routes
  {
    path: 'calculator',
    component: CalculatorComponent,
  },

  // otherwise redirect to home
  { path: '**', component: HomeComponent }
];

export const routing = RouterModule.forRoot(appRoutes);
