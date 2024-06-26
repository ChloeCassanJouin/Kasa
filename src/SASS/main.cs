body {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  width: 100%;
  overflow-x: hidden;
}

html {
  box-sizing: border-box;
}

*, *:before, *:after {
  box-sizing: inherit;
}

.header {
  padding: 10px 50px 10px 50px;
  display: flex;
  justify-content: space-between;
  overflow-x: hidden;
}
.header .header__logo {
  display: flex;
  justify-content: center;
  align-items: center;
}
.header .LogoHeader {
  height: 35px;
}
.header nav ul {
  list-style: none;
  display: flex;
  gap: 2em;
}
.header nav ul a {
  text-decoration: none;
  text-transform: lowercase;
  color: black;
  font-size: 15px;
}
.header nav ul a:hover {
  text-decoration: underline;
}

/* Media Queries */
@media screen and (max-width: 768px) {
  .header {
    padding: 20px 15px 20px 15px;
    max-width: 100%;
  }
  .header .header__nav .nav-link {
    text-transform: uppercase;
  }
  .header .logo img {
    max-width: 100px;
  }
}
.nav ul {
  flex-direction: column;
}
.nav ul li {
  margin: 10px 0;
}

.Lodging {
  padding: 30px;
  background-color: rgba(247, 244, 244, 0.938);
  margin: 40px 50px;
  border-radius: 20px;
  box-sizing: border-box;
}
.Lodging .LodgingCardsContainer {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  gap: 30px;
}
.Lodging .LodgingCardsContainer a {
  text-decoration: none;
  color: white;
}
.Lodging .LodgingCardsContainer a .LodgingCard {
  background: linear-gradient(rgba(224, 40, 40, 0.79), rgba(181, 13, 13, 0.95));
  border-radius: 5%;
}
.Lodging .LodgingCardsContainer a .LodgingCard:hover {
  transform: translateY(-5px);
  box-shadow: 0px 4px 6px rgba(229, 117, 117, 0.848);
  cursor: pointer;
}
.Lodging .LodgingCardsContainer a img {
  width: 100%;
  height: 200px;
  padding: 3px 3px 3px;
  border-radius: 5%;
}
.Lodging .LodgingCardsContainer a .LodgingTitleContainer {
  display: flex;
  justify-content: center;
  height: 50px;
  border-radius: 5%;
}
.Lodging .LodgingCardsContainer a .LodgingTitleContainer .LodgingTitle {
  margin: 0;
  font-size: 13px;
  display: flex;
  align-items: center;
  padding: 0 30px;
  text-align: center;
  padding-bottom: 9px;
}
.Lodging .LodgingCardsContainer a .LodgingTitleContainer .LodgingTitle ul {
  display: flex;
  flex-direction: row;
}

/* Media Queries */
@media screen and (max-width: 768px) {
  .Lodging {
    margin: 20px 15px;
    padding: 0;
    background-color: white;
  }
  .Lodging .LodgingCardsContainer {
    display: flex;
    flex-direction: column;
  }
}
.footer {
  background-color: black;
  padding: 2px 0;
  text-align: center;
  color: #fff;
}
.footer .footer_logo {
  padding-top: 25px;
}
.footer .LogoFooter {
  height: 20px;
}
.footer p {
  text-align: center;
  font-size: 11px;
  padding-bottom: 5px;
}

/* Media Queries */
@media screen and (max-width: 768px) {
  .footer {
    Height: 140px;
  }
  .footer .footer_logo {
    padding-top: 40px;
  }
  .footer p {
    padding: 0 130px 30px 130px;
  }
}
.BannerContainer {
  display: flex;
  max-width: 100%;
  padding: 0 50px;
  box-sizing: border-box;
  position: relative;
}
.BannerContainer .homePageBanner {
  width: 100%;
  max-width: 100%;
  height: 8em;
  border-radius: 20px;
  filter: brightness(50%);
  box-shadow: 0px 4px 6px rgb(245, 239, 239);
}
.BannerContainer .aboutBanner {
  width: 100%;
  max-width: 100%;
  height: 10em;
  border-radius: 30px;
  filter: brightness(80%);
}
.BannerContainer .BannerTextContainer {
  position: absolute;
  left: 50%;
  top: 30%;
  width: 100%;
}
.BannerContainer .break-point::after {
  content: "";
}
.BannerContainer .BannerText {
  transform: translate(-50%, -50%);
  text-align: center;
  z-index: 1;
  width: auto;
  color: white;
  position: absolute;
  font-size: 30px;
  font-weight: bold;
}

/* Media Queries */
@media screen and (max-width: 768px) {
  .BannerContainer {
    padding: 0 15px;
  }
  .BannerContainer .break-point::after {
    content: "\a";
    white-space: pre;
  }
  .BannerContainer .BannerText {
    text-align: start;
  }
  .BannerContainer p {
    padding: 0 70px 0px 40px;
    text-align: left;
  }
}
.about-content {
  padding: 0 110px;
}
.about-content .accordion {
  margin: 20px 0;
  background-color: rgba(224, 40, 40, 0.79);
  border-radius: 5px;
  overflow: hidden;
  transition: all 0.6s ease;
}
.about-content .accordion-title {
  background: rgba(224, 40, 40, 0.79);
  cursor: pointer;
  padding: 10px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.about-content .accordion-title h2 {
  margin: 0;
  font-size: 1.2rem;
  font-weight: 600;
  color: white;
}
.about-content .accordion-title .accordion-arrow img {
  width: 1.5rem;
  transition: transform 0.3s ease;
  color: white;
}
.about-content .accordion-title .accordion-arrow .rotate {
  transform: rotate(-180deg);
}
.about-content .accordion-content {
  padding: 15px;
  background: rgb(245, 239, 239);
  transition: max-height 0.6s cubic-bezier(0.25, 0.8, 0.5, 1), padding 0.6s cubic-bezier(0.25, 0.8, 0.5, 1), opacity 0.6s cubic-bezier(0.25, 0.8, 0.5, 1), visibility 0.6s cubic-bezier(0.25, 0.8, 0.5, 1);
  overflow: hidden;
  max-height: 0;
  opacity: 0;
  visibility: hidden;
  display: none;
}
.about-content .accordion-content.open {
  max-height: 200px;
  padding: 15px;
  opacity: 1;
  visibility: visible;
  display: block;
}

@media (max-width: 768px) {
  .accordion-title {
    flex-direction: row;
    align-items: flex-start;
    padding: 0px;
  }
  .accordion-arrow img {
    align-self: flex-end;
  }
  .about-content {
    padding: 0 15px;
  }
  p {
    padding: 0px;
  }
}
.lodgingAccordionContainer {
  margin: 0 50px 20px 50px;
  display: flex;
  flex-direction: row;
  justify-content: space-between;
}
.lodgingAccordionContainer .lodgingAccordionColumn {
  width: 48%;
  transition: all 0.6s ease;
}
.lodgingAccordionContainer .lodgingAccordionColumn .lodgingAccordion {
  background-color: rgba(224, 40, 40, 0.79);
  border-radius: 5px;
  overflow: hidden;
  transition: all 0.6s ease;
  display: flex;
  gap: 150px;
  justify-content: space-between;
  padding: 0 10px;
  cursor: pointer;
}
.lodgingAccordionContainer .lodgingAccordionColumn .lodgingAccordion .lodgingAccordion-title {
  color: white;
}
.lodgingAccordionContainer .lodgingAccordionColumn .lodgingAccordion .lodgingAccordion-title h2 {
  margin: 0;
  font-size: 1.2rem;
  font-weight: 600;
  color: white;
}
.lodgingAccordionContainer .lodgingAccordionColumn .lodgingAccordionArrow {
  display: flex;
  align-items: center;
}
.lodgingAccordionContainer .lodgingAccordionColumn .lodgingAccordionArrow img {
  width: 1.5rem;
  transition: transform 0.3s ease;
  color: white;
}
.lodgingAccordionContainer .lodgingAccordionColumn .lodgingAccordionArrow img .rotate {
  transform: rotate(-180deg);
}
.lodgingAccordionContainer .lodgingAccordionColumn-content {
  padding: 15px;
  background: rgb(245, 239, 239);
  transition: max-height 0.6s cubic-bezier(0.25, 0.8, 0.5, 1), padding 0.6s cubic-bezier(0.25, 0.8, 0.5, 1), opacity 0.6s cubic-bezier(0.25, 0.8, 0.5, 1), visibility 0.6s cubic-bezier(0.25, 0.8, 0.5, 1);
  overflow: hidden;
  max-height: 0;
  opacity: 0;
  visibility: hidden;
  display: none;
}
.lodgingAccordionContainer .lodgingAccordionColumn-content.open {
  max-height: 200px;
  padding: 15px;
  opacity: 1;
  visibility: visible;
  display: block;
}

@media (max-width: 768px) {
  .lodgingAccordionContainer {
    flex-direction: column;
  }
  .lodgingAccordionContainer .lodgingAccordionColumn {
    width: 100%;
  }
  .lodgingAccordion {
    flex-direction: column;
    align-items: flex-start;
    padding: 10px;
  }
  .lodgingAccordion .lodgingAccordionArrow {
    align-self: flex-end;
  }
  .lodgingAccordion .lodgingAccordionArrow img {
    align-self: flex-end;
  }
  .lodgingAccordion-content {
    padding: 10px;
  }
}
.errorContainer {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.errorContainer .errorNumber {
  color: rgba(224, 40, 40, 0.79);
  font-size: 80px;
  font-weight: bold;
  margin: 40px;
}
.errorContainer .errorText1 {
  color: rgba(224, 40, 40, 0.79);
  margin-bottom: 40px;
}
.errorContainer .errorText2 {
  margin-bottom: 60px;
  font-size: 10px;
  color: black;
}

/* Media Queries */
@media screen and (max-width: 768px) {
  .errorText1 {
    padding: 0 20px;
    text-align: center;
  }
  .errorText1 .break {
    display: block;
  }
}
.carouselContainer {
  position: relative;
  background-color: rgba(247, 244, 244, 0.938);
  margin: 0 50px;
  border-radius: 20px;
  box-sizing: border-box;
  height: 250px;
}
.carouselContainer .carousel-slide {
  position: relative;
}
.carouselContainer .carouselPictures {
  height: 250px;
  width: 100%;
  object-fit: cover;
  border-radius: 10px;
}
.carouselContainer .prev-button, .carouselContainer .next-button {
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  background: none;
  border: none;
  cursor: pointer;
  outline: none;
  padding: 0;
}
.carouselContainer .prev-button img, .carouselContainer .next-button img {
  width: 30px;
  height: auto;
}
.carouselContainer .prev-button {
  left: 10px;
}
.carouselContainer .next-button {
  right: 10px;
}

.lodgingFormRows {
  display: flex;
  justify-content: space-between;
  padding: 0px 50px;
  flex-direction: column;
  /*.lodgingFormRow1, .lodgingFormRow2 {
      flex: 1;

      .lodgingFormTitle {
        font-size: 24px;
        margin: 15px 0px 0px;
        font-weight: bold;
        color: rgba(224, 40, 40, 0.79); 
      }

      .lodgingFormLocation{
        margin: 0px;
        font-size: 12px;
      }

      .StarRatingContainer {
        margin-top: 35px;

        .star-rating {
            display: flex;
            gap: 5px;
            justify-content: flex-end;

            .star {
              width: 20px; 
              height: 20px;
            }
          }
      }

      ul {
        list-style: none;
        padding: 0px;
        margin-top: 10px;

        li {
          background-color: rgba(224, 40, 40, 0.79);
          border-radius: 15px;
          padding: 2px 20px;
          display: inline-block;
          margin-right: 5px;
          margin-bottom: 5px;
          color: white;
          font-size: 10px;
        }
      }
    }

    .lodgingFormColumn2 {
      text-align: right;

      .lodgingFormOwnerContainer {
        display: flex;
        align-items: center;
        justify-content: flex-end;
        gap: 10px;
        margin: 8px 0px 0px;
        padding-left: 220px;

        .lodgingFormOwnerAvatar {
          width: 40px; 
          height: 40px;
          background-color: grey;
          border-radius: 50%;

        }

        .lodgingFormOwner {
          color: rgba(224, 40, 40, 0.79);
        }
      }
    }
  }*/
  /* Media Queries */
}
.lodgingFormRows .lodgingFormRow1 {
  display: flex;
  flex-direction: column;
}
@media screen and (max-width: 768px) {
  .lodgingFormRows .lodgingFormColumns {
    flex-direction: column;
  }
  .lodgingFormRows .lodgingFormColumns .lodgingFormColumn1, .lodgingFormRows .lodgingFormColumns .lodgingFormColumn2 {
    text-align: left;
    padding: 0;
  }
  .lodgingFormRows .lodgingFormColumns .lodgingFormColumn1 ul, .lodgingFormRows .lodgingFormColumns .lodgingFormColumn2 ul {
    text-align: left;
  }
  .lodgingFormRows .lodgingAccordionContainer .lodgingAccordionColumn .lodgingAccordion {
    padding: 10px;
  }
  .lodgingFormRows .lodgingAccordionContainer .lodgingAccordionColumn > div {
    padding: 10px;
  }
}
@media screen and (max-width: 480px) {
  .lodgingFormRows .lodgingFormColumns {
    padding: 10px;
  }
  .lodgingFormRows .lodgingFormColumns .lodgingFormColumn1 .lodgingFormTitle, .lodgingFormRows .lodgingFormColumns .lodgingFormColumn2 .lodgingFormTitle {
    font-size: 20px;
  }
}

/*# sourceMappingURL=main.cs.map */
