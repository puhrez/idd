@-ms-viewport {
  width: device-width; }

/* http://meyerweb.com/eric/tools/css/reset/ 
   v2.0 | 20110126
   License: none (public domain)
*/
html, body, div, span, applet, object, iframe,
h1, h2, h3, h4, h5, h6, p, blockquote, pre,
a, abbr, acronym, address, big, cite, code,
del, dfn, em, img, ins, kbd, q, s, samp,
small, strike, strong, sub, sup, tt, var,
b, u, i, center,
dl, dt, dd, ol, ul, li,
fieldset, form, label, legend,
table, caption, tbody, tfoot, thead, tr, th, td,
article, aside, canvas, details, embed,
figure, figcaption, footer, header, hgroup,
menu, nav, output, ruby, section, summary,
time, mark, audio, video {
  margin: 0;
  padding: 0;
  border: 0;
  font-size: 100%;
  font: inherit;
  vertical-align: baseline; }

/* HTML5 display-role reset for older browsers */
article, aside, details, figcaption, figure,
footer, header, hgroup, menu, nav, section {
  display: block; }

body {
  line-height: 1; }

ol, ul {
  list-style: none; }

blockquote, q {
  quotes: none; }

blockquote:before, blockquote:after,
q:before, q:after {
  content: '';
  content: none; }

table {
  border-collapse: collapse;
  border-spacing: 0; }

body {
  margin: 0px auto;
  text-align: center;
  color: white;
  font-family: 'Roboto Condensed', sans-serif;
  background-color: black; }

img {
  max-width: 100%; }

em {
  font-style: italic;
  font-size: 1.25em; }

nav > ul {
  z-index: 2; }

nav ul li {
  border: 0.1em solid black;
  list-style-type: none;
  position: relative;
  text-align: left;
  font-size: 2em;
  height: 1.75em;
  background-color: white; }
  nav ul li ul {
    -webkit-transition: transform 0.2s linear 25ms;
    -moz-transition: transform 0.2s linear 25ms;
    -ms-transition: transform 0.2s linear 25ms;
    transition: transform 0.2s linear 25ms;
    position: absolute;
    z-index: -1;
    top: 0%; }
    nav ul li ul li {
      overflow: hidden;
      background-color: white;
      font-size: 0.7em;
      max-width: 175%; }

nav li:hover ul, .expose {
  transform: translate(-100%, -100%);
  z-index: -2; }

a {
  color: black;
  text-decoration: none;
  padding-right: 10%; }
  a:hover {
    color: blue; }

ul li {
  line-height: 200%; }

section {
  background-color: #FFFF99;
  color: black; }
  section article h1 {
    font-size: 2em;
    line-height: 250%;
    font-weight: bold; }
    section article h1 a {
      text-decoration: none; }
  section article h2 {
    font-size: 1.5em;
    line-height: 150%; }
  section article h5 {
    font-size: 1.25em;
    line-height: 150%; }
  section article p {
    font-size: 1em;
    text-indent: 1em;
    text-align: left;
    margin-left: 10%;
    margin-right: 10%;
    line-height: 150%; }
  section article ul > li {
    text-align: left;
    margin-left: 20%;
    margin-right: 20%;
    text-decoration: underline;
    font-size: 1.1em; }
  section article li + p {
    font-size: 0.75em;
    margin-left: 30%;
    margin-right: 30%; }

.container {
  background-color: white;
  color: black; }

.exampleSection em {
  text-decoration: underline; }
.exampleSection h5 {
  font-size: 1em;
  text-decoration: underline; }
.exampleSection p {
  font-family: 0.5em; }

.logo span {
  vertical-align: super;
  text-decoration: underline; }
.logo .address {
  display: show;
  text-align: left;
  font-weight: 300;
  font-style: italic;
  padding-bottom: 80%;
  width: 50%; }
  .logo .address li {
    line-height: 100%; }
.logo h2 {
  padding-top: 1%;
  padding-bottom: 5%;
  font-size: 2em;
  line-height: 75%; }

footer {
  background-color: black;
  color: white;
  text-align: left; }
  footer .logo {
    padding-top: 1%; }
  footer .address {
    font-weight: 300;
    text-align: left;
    font-style: italic;
    padding-top: 1%; }
    footer .address li {
      line-height: 100%; }

p.percentages {
  text-align: right;
  font-size: 2em;
  font-weight: bold;
  margin-right: 30%; }

.container nav {
  position: fixed;
  bottom: 0;
  right: 0;
  display: block; }

.mainNav {
  transition-duration: 1s;
  -webkit-transition-duration: 1s;
  -moz-transition-duration: 1s;
  -ms-transition-duration: 1s; }

.moveUp {
  transition-duration: 1s;
  -webkit-transition-duration: 1s;
  -moz-transition-duration: 1s;
  -ms-transition-duration: 1s;
  margin-top: -250%; }
