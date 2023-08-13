
<style lang="less">
    @import '../assets/css/animate.css';
    @import '../assets/css/bootstrap.min.css';
    @import '../assets/css/fontawesome.min.css';
    @import '../assets/css/owl.carousel.min.css';
    @import '../assets/css/twentytwenty.css';
    @import '../assets/css/fancybox/jquery.fancybox.min.css';
    @import '../assets/style.css';
    @import '../assets/css/responsive.css';
</style>

<template>
  <div>
  <div id="st-preloader">
        <div class="st-preloader-wave"><img src="../assets/images/st-loader.png" alt="preloader"></div>
    </div>
    <!-- preloader end -->

    <!--Main Wrapper Start-->
    <div class="wrapper" id="top">
        <!--Header Start -->
        <header class="main-header menu-absolute transparent light-header">
            <div class="container">
                <div class="row">
                    <div class="col-sm-3 logo">
                        <a href="/wheels/intro/" title="Wheels Car">
                            <img src="../assets/images/car-logo.png" alt="car" class="regular-logo">
                            <img src="../assets/images/car-dark-logo.png" alt="car" class="sticky-logo">
                        </a>
                        <div class="menu-icon">
                            <span class="top"></span>
                            <span class="middle"></span>
                            <span class="bottom"></span>
                        </div>
                    </div>
                    <div class="col-sm-9 menu-conainer">
                        <nav class="site-navigation">
                            <ul class="main-menu">
                                <li><a href="#about">سباق الهجن</a></li>
                                <li><a href="#technology">هجن الامارات</a></li>
                                <li><a href="#color">المعرض</a></li>
                                <li><a href="#accessories">احصائيات</a></li>
                                <li><a href="#dealer">عننا</a></li>
                                <li><router-link to="/login">تسجيل الدخول</router-link></li>
                            </ul>
                            <ul class="header-social-media">
                                <li><a href="#"><i class="fab fa-facebook-f"></i></a></li>
                                <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                                <li><a href="#"><i class="fab fa-youtube"></i></a></li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </header>
        <!--Header End-->
        <!-- Content Section Start -->   
       <div class="main-container">
            <!-- Hero Section Start -->
           <section id="home" class="height-100 hero-section style-1 light-text">
               <div class="section-background">
                   <div class="background-wrapper">
                        <img src="../assets/images/bg-1-new.jpg" alt="background-inner" />
                   </div>
               </div>
               <div class="container double-top-padding double-bottom-padding">
                   <div class="row">
                       <div class="col-lg-8 col-md-8 banner-content">
                           <h2 class="top-sub-heading"></h2>
                           <h1 class="large-heading"><span>سباق</span>الرئاسة</h1>
                           <div class="text-block text-lead">
                               <p>يعتبر سباق الهجن أحد السباقات العربية الأصيلة </p>
                           </div>
                           <!--<div class="btn-wrapper">
                               <a class="btn btn-primary btn-accent has-icon" href="#book-ride"><span>Download brochure</span><i class="fas fa-arrow-right"></i></a>

                           </div>-->
                       </div>
                   </div>
               </div>
           </section>
            <!-- Hero Section End -->
            <!-- About Section Start -->
            <section id="about" class="about-section">
                <div class="container">
                    <div class="row">
                        <div class="col-md-10 offset-md-1 text-center">
                            <div class="heading-wrapper">
                                <h2 class="large-heading text-uppercase"><span>سباق</span>الهجن</h2>
                            </div>
                            <div class="text-block text-lead">
                                <p>رياضة سباقات الهجن تعد من السباقات الشعبية والعربية الأصيلة، حيث تحظى هذه الرياضة باهتمام كبير في دولة الإمارات العربية المتحدة، وتتمتع بمكانة طيبة في العديد من الدول خاصة، السعودية، السودان، مصر، المغرب، الأردن، الكويت وعمان. سباق الهجن يتمثل في ركوب المطية من قبل المتسابقين والركض نحو خط النهاية</p>
                            </div>
                            <div class="btn-wrapper">
                                <a data-fancybox href="https://www.youtube.com/watch?v=irZBEKguKGk" class="btn btn-primary has-icon"><span>للمشاهدة</span><i class="fas fa-play"></i></a>
                                <!--<a data-fancybox href="https://youtu.be/3kySIdRBdEM" class="btn btn-primary btn-accent play-btn"><i class="fas fa-play"></i></a>-->
                            </div>
                            <div class="empty-30"></div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="before-after-car-container">
                                <img src="../assets/images/x1.png" alt="" />
                                <img src="../assets/images/x3.png" alt="" />
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- About Section End -->
            <!-- Technology Section Start -->
            <section id="technology" class="technology-section gray-bg">
                <div class="section-background">
                    <div class="background-wrapper">
                        <div class="background-inner" style="background-image: url('../assets/images/bg-2.png'); background-repeat: no-repeat;background-position: center center; background-size:auto;"></div>
                    </div>
                </div>
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-wrapper text-center">
                                <h2 class="large-heading text-uppercase"><span>هجن</span>الامارات</h2>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="small-container">
                    <div class="row features-row">
                        <div class="col-md-3">
                            <div class="feature-box">
                                <div class="feature-icon">
                                    <img src="../assets/images/icon-01.png" alt="">
                                </div>
                                <div class="features-text">
                                    <p>في سباق الهجن في الامارات تُعرف الإبل التي تتنافس في سباق الإبل بأبناء أو بنات الإبل الأصيلة وتشتهر بأنها أصيلة السلالة، من سلالات السلالات العربية الأصلية.</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="feature-box offset-y-100">
                                <div class="feature-icon">
                                    <img src="../assets/images/icon-02.png" alt="">
                                </div>
                                <div class="features-text">
                                    <p> بالإضافة إلى خصائصها العامة التي تشترك فيها مع الإبل الأخرى، فهي تتميز بسمات خاصة تجعلها قادرة على الجري بسرعة.</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="feature-box">
                                <div class="feature-icon">
                                    <img src="../assets/images/icon-03.png" alt="">
                                </div>
                                <div class="features-text">
                                    <p>وتتميز بحدبة واحدة وعنق طويل وأكتاف قوية وأرجل قوية ويزن كل منهم ما بين 500 و600 كيلوغرام.</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="feature-box offset-y-100">
                                <div class="feature-icon">
                                    <img src="../assets/images/icon-04.png" alt="">
                                </div>
                                <div class="features-text">
                                    <p> بالإضافة إلى ذلك، فإن النحافة، وخفة الحركة، وسرعة الجري، والقدرة على التحمل والاستجابة التدريبية لجمال سباق الهجن في الامارات تميزها عن غيرها.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="btn-wrapper text-center p-top-50">
                                <a href="" class="btn btn-primary accent-color has-icon"><span>View All Features</span><i class="fas fa-arrow-right"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- Technology Section End -->
            <!-- Color Section Start -->
            <section id="color" class="gallery-section black-bg light-text">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="gallery-slider owl-carousel overflow-show">
                                <div class="item">
                                    <img src="../assets/images/gallery-slide-1.png" alt="">
                                </div>
                                <div class="item">
                                    <img src="../assets/images/gallery-slide-2.png" alt="">
                                </div>
                                <div class="item">
                                    <img src="../assets/images/gallery-slide-3.png" alt="">
                                </div>
                                <div class="item">
                                    <img src="../assets/images/gallery-slide-4.png" alt="">
                                </div>
                                <div class="item">
                                    <img src="../assets/images/gallery-slide-5.png" alt="">
                                </div>
                                <div class="item">
                                    <img src="../assets/images/gallery-slide-6.png" alt="">
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- Power Section Start -->
            <!--<section id="engine" class="power-section black-bg light-text">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-8 col-md-12">
                            <div class="heading-wrapper m-bot-0">
                                <h2 class="large-heading text-uppercase m-bot-0">Powerful</h2>
                            </div>
                            <div class="text-block text-lead">
                                <h3 class="h1 fw-300">Handcrafted Engine</h3>
                                <p>GLA999 comes with 999 horsepower motor. The Engine will get up to speed of 180 mph in seconds.</p>
                            </div>
                            <div class="row power-icon">
                                <div class="col">
                                    <div class="icon-img"><img src="../assets/images/MeximumPower-icon.png" alt=""></div>
                                    <h4 class="icon-title text-uppercase">Maximum Power</h4>
                                    <div class="icon-text">
                                        419 KW(570 CV)
                                        <span>at 9000 rpm</span>
                                    </div>
                                </div>
                                <div class="col">
                                    <div class="icon-img"><img src="../assets/images/speed-icon.png" alt=""></div>                                
                                    <h4 class="icon-title text-uppercase">Acceleration 0-60km/h</h4>
                                    <div class="icon-text">
                                        3.4 SEC
                                        <span>0-60km/h</span>
                                    </div>
                                </div>
                                <div class="col">
                                    <div class="icon-img"><img src="../assets/images/car-body-icon.png" alt=""></div>        
                                    <h4 class="icon-title text-uppercase">Body</h4>
                                    <div class="icon-text">
                                        Retractable
                                        <span>Hard-top</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-4 col-md-12 text-center">
                            <div class="image-wrapper">
                                <img src="../assets/images/car-engine.png" alt="" class="engine-ico" />
                                <audio controls id="audio">
                                    <source src="audio/carstartgarage.ogg" type="audio/wav">
                                    <source src="audio/carstartgarage.mp3" type="audio/mpeg">
                                </audio> 
                            </div>
                            <div class="btn-wrapper start-engine m-top-30">
                                <a href="#" class="btn btn-primary btn-accent has-icon"><span>Start the Engine</span><i class="fas fa-volume-up"></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </section>-->
            <!-- Accessories Section Start -->
            <section id="accessories" class="accessories-section pb-0">
                <div class="container">
                    <div class="row statit">
                        <h2 class="large-heading text-uppercase"><span>هجن</span>احصائيات</h2>
                        <div class="wrapperss">
                            <div class="gauge">
                                <div class="slice-colors">
                                    <div class="st slice-item"></div>
                                    <div class="st slice-item"></div>
                                    <div class="st slice-item"></div>
                                    <div class="st slice-item"></div>
                                    <div class="st slice-item"></div>
                                </div>
                                <div class="needle"></div>
                                <div class="gauge-center"></div>
                            </div>
                        </div>
                        <img src="../assets/images/accessories-bg.png" alt="" />
                    </div>
                   
                </div>
                
            </section>
            <!-- book-ride Section Start -->
            <!--<section id="book-ride" class="bookride-section light-text">
                <div class="section-background">
                    <div class="background-wrapper">
                        <div class="background-inner" style="background-image: url('../assets/images/bg-10.jpg'); background-repeat: no-repeat;background-position: center bottom; background-size:cover;"></div>
                        <div class="overlay-bg" style="background-color:#dd0606; opacity:0.85;"></div>
                    </div>
                </div>
                 <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-wrapper text-center">
                                <h2 class="large-heading text-uppercase">Book a Test Ride</h2>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <form class="transparent-field">
                                <div class="form-row">
                                    <div class="form-group col-md-4">
                                        <input type="text" name="full-name" class="form-control" placeholder="Your full Name" required="required">
                                    </div>
                                    <div class="form-group col-md-4">
                                        <input type="email" name="email" class="form-control" placeholder="Email ID" required="required">
                                    </div>
                                    <div class="form-group col-md-4">
                                        <input type="text" name="mobile" class="form-control" placeholder="Mobile" required="required">
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-group col-md-4">
                                        <select class="form-control" name="country">
                                            <option value="">Select Country</option>
                                            <option value="Country 1">Country 1</option>
                                            <option value="Country 2">Country 2</option>
                                            <option value="Country 3">Country 3</option>
                                            <option value="Country 4">Country 4</option>
                                            <option value="Country 5">Country 5</option>
                                        </select>
                                    </div>
                                    <div class="form-group col-md-4">
                                        <select class="form-control" name="state">
                                            <option value="">Select State</option>
                                            <option value="State 1">State 1</option>
                                            <option value="State 2">State 2</option>
                                            <option value="State 3">State 3</option>
                                            <option value="State 4">State 4</option>
                                            <option value="State 5">State 5</option>
                                        </select>
                                    </div>
                                    <div class="form-group col-md-4">
                                        <select class="form-control" name="state">
                                            <option value="">Select City</option>
                                            <option value="city 1">City 1</option>
                                            <option value="city 2">City 2</option>
                                            <option value="city 3">City 3</option>
                                            <option value="city 4">City 4</option>
                                            <option value="city 5">City 5</option>
                                        </select>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-group col-md-12">
                                        <textarea placeholder="Remarks/Suggestions" class="form-control" name="comments"></textarea>
                                    </div>
                                </div>
                                <div class="form-row">
                                    <div class="form-group col-md-12 text-center">
                                        <input type="submit" value="Submit">
                                    </div>
                                </div>
                            </form>
                        </div>
                    </div>
                </div>
            </section>-->
            <!-- Find Dealer Section Start -->
            <section id="dealer" class="dealer-section">
                 <div class="container">
                    <div class="row">
                        <div class="col-md-12">
                            <div class="heading-wrapper">
                                <h4 class="large-heading text-uppercase">متى تأسس سباق الهجن؟</h4>
                            </div>
                            <div class="text-block text-lead">                                
                                <p>بالإضافة إلى ذلك تم تطوير نظام التسجيل في السباقات ليواكب أحدث التقنيات من خلال خدمة الكترونية فريدة تقدم لملاك الهجن لأول مرة في تاريخ هذه الرياضة. · نظم أول سباق للهجن في قطر عام 1973م بمنطقة الفرع التي تقع غرب منطقة الشحانية بحوالي 9 كيلو مترات واشتركت فيه 300 من الهجن. </p>
                            </div>
                        </div>
                        <div class="col-md-12">
                            <div class="heading-wrapper">
                                <h4 class="large-heading text-uppercase">من الدول التي يقام فيها سباق الهجن؟</h4>
                            </div>
                            <div class="text-block text-lead">
                                <p>كان يتم سباق الهجن في الامارات قديما ضمن نطاق فردي أو جماعي، وعلى مستوى الأسرة أو القبيلة، وخاصةً في المناسبات الرسمية والأعياد وحفلات الزواج وما إلى ذلك، وقد حظي سباق الهجن باهتمام كبير في عدد من الدول الأوروبية كذلك، حيث تم تنظيم ثلاثة سباقات ناجحة خلال عامي 1998 و1999 في كل من ألمانيا وأستراليا </p>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
            <!-- Find Dealer Section End -->
       </div>
        <!-- Content Section End -->   
        <!--footer Start-->   
        <footer class="site-footer">
            <div class="footer-widget-area">
                <div class="container">
                    <div class="row">
                        <div class="col-lg-4 col-md-6 col-sm-6">
                            <div class="widget">
                                <div class="widget-heading">
                                    <h4 class="widget-title">نبذة مختصرة</h4>
                                </div>
                                <div class="widget-contet">
                                    <img src="../assets/images/car-logo.png" class="footer-logo" alt="" />
                                    <p>رياضة سباقات الهجن تعد من السباقات الشعبية والعربية الأصيلة، حيث تحظى هذه الرياضة باهتمام كبير في دولة الإمارات العربية المتحدة</p>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-2 col-md-6 col-sm-6">
                            <div class="widget">
                                <div class="widget-heading">
                                    <h4 class="widget-title">روابط مختصرة</h4>
                                </div>
                                <div class="widget-contet footer-menu">
                                    <ul class="menu">
                                        <li><a href="#about">سباق الهجن</a></li>
                                        <li><a href="#technology">هجن الامارات</a></li>
                                        <li><a href="#color">المعرض</a></li>
                                        <li><a href="#accessories">احصائيات</a></li>
                                        <li><a href="#dealer">عننا</a></li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                         <div class="col-lg-3 col-md-6 col-sm-6">
                            <div class="widget">
                                <div class="widget-heading">
                                    <h4 class="widget-title">معومات الاتصال</h4>
                                </div>
                                <div class="widget-contet contact-info">
                                    <div class="widget-contact-info">
                                        <i class="fas fa-phone"></i>
                                        <h3>رقم الهاتف</h3>
                                        <span><a href="+01(123) 456 7890">+01(123) 456 7890</a></span>
                                    </div>
                                    <div class="widget-contact-info">
                                        <i class="fas fa-envelope-open"></i>
                                        <h3>البريد الالكتروني</h3>
                                        <span><a href="mailtp:info@wheels.com">info@wheels.com</a></span>
                                    </div>
                                    <div class="widget-contact-info">
                                        <i class="fas fa-map-marker-alt"></i>
                                        <h3>العنوان</h3>
                                        <span>30 الطريق السريع <br />الامارات</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-3 col-md-6 col-sm-6">
                            <div class="widget">
                                <div class="widget-heading">
                                    <h4 class="widget-title">Subscribe</h4>
                                </div>
                                <div class="widget-contet">
                                    <div class="newsletter-box">
                                        <form method="post">
                                            <input type="email" name="email" placeholder="Enter Email Address" required="" autocomplete="off" class="form-control">
                                            <button type="submit" class="signup-btn">Sign Up</button>
                                        </form>
                                    </div>
                                </div>
                            </div>
                            <div class="widget">
                                <div class="widget-heading">
                                    <h4 class="widget-title">Follow Us</h4>
                                </div>
                                <div class="widget-contet">
                                    <div class="footer-social">
                                        <ul>
                                            <li><a href="#"><i class="fab fa-facebook-f"></i></a></li>
                                            <li><a href="#"><i class="fab fa-twitter"></i></a></li>
                                            <li><a href="#"><i class="fab fa-youtube"></i></a></li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class="copyright text-center">
                <div class="container">
                    <div class="copyright-text">© 2020 Wheels. Design & Developed by <a target="_blank" href="http://sacredthemes.net/">SacredThemes</a>.</div>
                </div>
            </div>
        </footer>
        <!--footer end-->   
    </div>
  </div>
</template>
<script lang="ts">
import { Component, Vue,Inject } from 'vue-property-decorator';
import iView from 'iview';
import AbpBase from '../lib/abpbase'
@Component({
  components:{}
})
export default class Dashboard extends AbpBase {

  created() {
    var scripts = [
      "/dist/theme.js",
      "/dist/custom.js",
      "/dist/main.js"
    ];
    scripts.forEach(script => {
      let tag = document.createElement("script");
      tag.setAttribute("src", script);
      document.head.appendChild(tag);
    });
  }

}
</script>