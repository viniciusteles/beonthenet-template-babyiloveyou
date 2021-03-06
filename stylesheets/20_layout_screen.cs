html * {
	padding:                0;
	border:                 none;
	outline:                none;
	margin:                 0;
}

hr, ul#thumbnails li.empty {
  display:                block;
  float:                  none;
  height:                 0;
  padding:                0;
  margin:                 0;
  clear:                  both;
  visibility:             hidden;
}

body {
  width:                  900px;
  margin:                 40px auto;
}


/* Header */
#header {
  min-height:             100px;
  height:                 auto !important;
  height:                 100px;
  padding:                20px 0;
  position:               relative;
}

#logo_print, #logo_print img {
  display:                none;
}

#logo_screen, #slogan, #header ul, #global_search #query {
  position:               absolute;
}

#logo_screen {
  padding:                0 0 10px 0;
  width:                  280px;
  top:                    25px;
  left:                   40px;
}

#slogan {
  bottom:                 20px;
  left:                   20px;
}

#header ul {
  width:                  540px;
  right:                  20px;
  bottom:                 5px;
}

#header li {
  border:                                       1px dotted green;
  float:left;
/*  display:                inline;*/
/*  margin:0 !important;*/
}

#header li a {
  display:block;
  
/*  border:                                     1px dotted gray;*/
  padding:                8px 25px;
  margin:                 0;
}
#header li a:active {
  position:               relative;
  top:                    1px;
}

#global_search {
  width:                  auto;
}

#global_search #query {
  width:                  160px;
  padding:                0 8px;
  border:                 3px solid;
  top:                    -20px;
  right:                  0;

  -moz-border-radius-topleft:       10px;
  -webkit-border-top-left-radius:   10px;
  -moz-border-radius-topright:      10px;
  -webkit-border-top-right-radius:  10px;
}

*[type="hidden"] {
  display:                none;
}
/* Header */


/* Main content */
#main_content {
  padding:                0 40px 40px 40px;
  border:                 2px solid;
}

#main_content h1 {
  padding:                24px 0 0 0;
  margin-bottom:          8px;
  position:               relative;
  z-index:                2;
}

#main_content h2 {
  padding:                56px 0 0 0;
  margin-bottom:          -80px;
}

#subnavigation {
  padding:                8px 0;
  margin-left:            320px;
}

#subnavigation a {
  margin-left:            64px;
}
/* /Main content */


/* Thumbnails list */
#thumbnails {
/*  margin-top:             32em;*/
  border:1px dotted blue;
/*  margin-left:-2.5em;*/
/*  margin-right:-2.5em;*/
}

#thumbnails li {
/*  border:1px dotted red;*/
  width:290px;
  position:relative;

  float:                  left;
  margin:                 2.5em 3em 2.5em 1em;
}
#thumbnails > li {
/*  margin:                 2.5em 2em 2.5em 2em;*/
  margin:                 2.5em 2em 2.5em 5em;
}

#thumbnails h2 {
  margin-bottom:          .5em;
  
  position:absolute;
  left:0;
  bottom:295px;
  width:100%;
}

#thumbnails h3 {
/*  display:                none;*/
position:absolute;
right:0;
bottom:287px;
/*width:30px;*/
/*border:1px dashed blue;*/
width:100%;
font-size: 80%;
text-align:center;
z-index:1;
}

#thumbnails h3 a {
/*font-family:serif;*/
  color:#415579;
  text-decoration:none;
}

/* Vertically centering images 
(conditional comments for IE required) */
#thumbnails div a {
/*  display:                table-cell;*/
  width:                  290px;
  height:                 285px;
/*  vertical-align:         middle;*/
}


#thumbnails div img {
  border:                 2px solid;
  position:               relative;
  top:                    -10px;
  left:                   13px;
}
body.videos #thumbnails div img {
/*  max-width:              240px;*/
  width:                  240px;
}

body#gallery #thumbnails, 
body#search #thumbnails {
  margin:                 0 -2.5em;
}

body#gallery #thumbnails li, 
body#search #thumbnails li {
  padding:                0 .3em;
  margin:                 0 0 20px 0;
}

body#gallery #thumbnails div a, 
body#search #thumbnails div a {
  width:                  250px;
  height:                 250px;
  padding:                0;
  background:             none;
}

body#gallery #thumbnails div img, 
body#search #thumbnails div img {
  padding:                4px;
  border:                 1px solid;
  position:               static;
}
/* /Thumbnails list */


/* Summary */
#summary {
  padding:                25px 30px .1em 30px;
  margin:                 -2em -1.25em 0 0;
}
body#big_picture #summary, 
body#search_picture #summary {
  margin-top:             .1em;
}
/* /Summary */


/* Big picture, big video */
#big_picture {
  width:                  63.25em;
  min-height:             140px;
  height:                 auto !important;
  height:                 140px;
  margin-right:           -50%;
  position:               relative;
  right:                  22.9%;
  overflow:               hidden;
}

#big_picture a {
	width:                  5.6em;
	padding:                1em .3em .5em .3em;
	position:               absolute;
  top:                    0;
  z-index:                1;
}
#big_picture #previous {
  left:                   13.75em;
}
#big_picture #next {
  right:                  13.75em;
}

#big_picture label {
/*  display:                none;*/
}
/* /Big picture, big video */


/* Tags and searchable items */
#tags {
  margin:                 .25em 0 1.5em 0;
}

#tags a, 
#valid_search_suggestions a {
  margin:                 0 .75em;
}

#valid_search_suggestions {
  margin-top:             1.5em;
}

#valid_search_suggestions li {
  display:                inline;
}
/* /Tags and searchable items */


/* Contact form */
form {
  width:                  60%;
  margin:                 auto;
}

form label, input, textarea, button {
  display:                block;
}

input, textarea {
  width:                  100%;
  padding:                .2em;
  border:                 2px dashed;
  margin-bottom:          .75em;
}

label#subject, input#message_subject, 
label#wedding_date, input#message_wedding_date, 
label#wedding_place, input#message_wedding_place {
/*  display:                none;*/
}

textarea {
  height:                 15em;
}

button {
  width:                  20%;
  padding:                .2em;
  margin:                 auto;
}

button.submitting {
  width:                  auto;
  padding-right:          2.5em;
}
/* /Contact form */


/* Errors and Successes */
.email_field_with_errors {
  border:                 2px solid;
}
/* Errors and Successes */


/* Error pages */
body.application #main_content h2 {
  height:                 9.75em;
  padding:                1em 360px 1em 0;
  margin:                 0em 0 3em 0;
}

body.application #main_content h3 {
  margin-bottom:          1.5em;
}

.error_hints {
  margin:                 1.5em 10em;
}

.error_hints li {
  margin-bottom:          1em;
}
/* /Error pages */


/* Footer */
#footer {
  padding:                .75em 2.5em 1.5em 2.5em;
}

#footer p {
  margin-bottom:          .5em;
}

#beonthenet img {
  width:                  95px;
  height:                 22px;
  margin:                 0 -4px -3px 0;
}

#footer h3 {
  margin-top:             .5em;
}

#footer h5 {
  margin:                 2em 0 .5em 0;
}
/* /Footer */


/* Generated content */
body#selection #main_content h1:after {
  display:                block;
  margin:                 2em 130px 0 130px;
  content:                "Desculpe, infelizmente a seleção de imagens ainda não está disponível neste template. Estamos cuidando disso. Se você chegou até aqui digitando na barra de endereços, use o menu no topo do site para navegar de volta às páginas desejadas.";

}
/* /Generated content */


/* Disappearing content */
#go_to_selection, 
#data_sheet, 
body#selection #main_content ul, 
body#selection #main_content h2, 
body#selection #main_content p.pages,
body#selection #main_content p.checkout,
body#selection #main_content p.pictures_sent {
  display:                none;
}
/* /Disappearing content */


/* Text */
.text #main_content {
  padding-right:          170px;
  padding-left:           170px;
}

.text #main_content h1, 
.text #main_content h2, 
.text #main_content h3 {
  margin-right:           -130px;
  margin-left:            -130px;
}

p {
/*  margin:                 .5em 0 .75em 0;*/
}
/* /Text */