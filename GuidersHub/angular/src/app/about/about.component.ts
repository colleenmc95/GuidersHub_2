import { Component, Injector, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import { NgxGalleryOptions, NgxGalleryImage, NgxGalleryAnimation} from 'ngx-gallery';

@Component({
    templateUrl: './about.component.html',
    animations: [appModuleAnimation()],
    styleUrls: ['./about.component.less']
})
export class AboutComponent extends AppComponentBase {
    galleryOptions: NgxGalleryOptions[];
    galleryImages: NgxGalleryImage[];

    constructor(
        injector: Injector
    ) {
        super(injector);
        this.galleryOptions=[
            {
                width: '600px',
                height: '400px',
                thumbnailsColumns: 4,
                imageAnimation: NgxGalleryAnimation.Slide
            },
            {
                breakpoint: 800,
                width: '100%',
                height: '600px',
                imagePercent: 80,
                thumbnailsPercent: 20,
                thumbnailMargin:20,
                thumbnailsMargin: 20
            },
            {
              breakpoint: 400,
              preview: false  
            }
        ];
        this.galleryImages = [
            {
                small: 'assets/slideshow_1sm.jpg',
                medium: 'assets/slideshow_1m.jpg',
                big: 'assets/slideshow_1bg.jpg'
            },
            {
                small: 'assets/slideshow_1sm',
                medium: 'assets/slideshow_1m',
                big: 'assets/slideshow_1bg'
            },
            {
                small: 'assets/slideshow_1sm',
                medium: 'assets/slideshow_1m',
                big: 'assets/slideshow_1bg'
            },
            {
                small: 'assets/slideshow_1sm',
                medium: 'assets/slideshow_1m',
                big: 'assets/slideshow_1bg'
            }
            
        ];
    }
}
