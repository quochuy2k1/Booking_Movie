import{bF as h,j as a,z as l,bI as m}from"./styles.3449b18f.js";import{A as b,k as L}from"./admin.23e9f2fc.js";import{L as p}from"./Link.6fb5531f.js";const c=({color:t,outline:n,size:s,sx:r,...o})=>{const e=h(),g=t&&!n&&{color:e.palette.background.paper,bgcolor:`${t}.main`},d=n&&{color:t?`${t}.main`:"primary.main",bgcolor:e.palette.background.paper,border:"2px solid",borderColor:t?`${t}.main`:"primary.main"};let i={};switch(s){case"badge":i={width:e.spacing(3.5),height:e.spacing(3.5)};break;case"xs":i={width:e.spacing(4.25),height:e.spacing(4.25)};break;case"sm":i={width:e.spacing(5),height:e.spacing(5)};break;case"lg":i={width:e.spacing(9),height:e.spacing(9)};break;case"xl":i={width:e.spacing(10.25),height:e.spacing(10.25)};break;case"md":i={width:e.spacing(7.5),height:e.spacing(7.5)};break;default:i={}}return a(b,{sx:{...g,...d,...i,...r},...o})},V=({title:t,link:n,icon:s})=>{const r=h();return a(L,{title:t||"Reference",placement:"left",children:l(m,{disableRipple:!0,children:[!s&&a(c,{component:p,href:n,target:"_blank",alt:"MUI Logo",size:"badge",color:"primary",outline:!0,children:l("svg",{width:"500",height:"500",viewBox:"0 0 500 500",fill:"none",xmlns:"http://www.w3.org/2000/svg",children:[l("g",{clipPath:"url(#clip0)",children:[a("path",{d:"M100 260.9V131L212.5 195.95V239.25L137.5 195.95V282.55L100 260.9Z",fill:r.palette.primary[800].toString()}),a("path",{d:"M212.5 195.95L325 131V260.9L250 304.2L212.5 282.55L287.5 239.25V195.95L212.5 239.25V195.95Z",fill:r.palette.primary.main}),a("path",{d:"M212.5 282.55V325.85L287.5 369.15V325.85L212.5 282.55Z",fill:r.palette.primary[800].toString()}),a("path",{d:"M287.5 369.15L400 304.2V217.6L362.5 239.25V282.55L287.5 325.85V369.15ZM362.5 195.95V152.65L400 131V174.3L362.5 195.95Z",fill:r.palette.primary.main})]}),a("defs",{children:a("clipPath",{id:"clip0",children:a("rect",{width:"300",height:"238.3",fill:"white",transform:"translate(100 131)"})})})]})}),s&&a(c,{component:p,href:n,target:"_blank",size:"badge",color:"primary",outline:!0,children:s})]})})};export{V as C};
