import{bF as qe,au as xe,av as c,R as G,r as n,ca as Ke,z as h,F as me,B as N,j as e,I as Le,b7 as Xe,ae as r,aD as x,cM as et,cb as tt,an as $e,cc as at,cN as nt,aB as pe,cO as ot,cP as it,cQ as lt,cR as st,cS as rt,ce as ct}from"./styles.3449b18f.js";import{u as Je,v as Ve,w as ze,x as Ue,y as Re,z as f,E as We,B as je,G as _e,H as fe,J as dt,M as ut,K as ht,n as gt,N as pt,P as xt,Q as mt,R as ft,U as Et,V as Ct,A as vt,q as Dt}from"./admin.23e9f2fc.js";function yt(a){return a=a.toLowerCase(),a=a.replace(/à|á|ạ|ả|ã|â|ầ|ấ|ậ|ẩ|ẫ|ă|ằ|ắ|ặ|ẳ|ẵ/g,"a"),a=a.replace(/è|é|ẹ|ẻ|ẽ|ê|ề|ế|ệ|ể|ễ/g,"e"),a=a.replace(/ì|í|ị|ỉ|ĩ/g,"i"),a=a.replace(/ò|ó|ọ|ỏ|õ|ô|ồ|ố|ộ|ổ|ỗ|ơ|ờ|ớ|ợ|ở|ỡ/g,"o"),a=a.replace(/ù|ú|ụ|ủ|ũ|ư|ừ|ứ|ự|ử|ữ/g,"u"),a=a.replace(/ỳ|ý|ỵ|ỷ|ỹ/g,"y"),a=a.replace(/đ/g,"d"),a=a.replace(/\u0300|\u0301|\u0303|\u0309|\u0323/g,""),a=a.replace(/\u02C6|\u0306|\u031B/g,""),a.replaceAll(" ","_")}const Ge=".jpg, .png, image/*",bt="video/*",At=[{key:1,text:"Phim \u0111ang chi\u1EBFu",value:!0},{key:2,text:"Phim s\u1EAFp chi\u1EBFu",value:!1}],St=()=>{const a=qe(),A=xe(),v=Je(a.breakpoints.down("md")),p=localStorage.getItem("token"),m=c(o=>o.movie.status),g=c(o=>o.movie.error),[w,E]=G.useState(!1),[B,C]=n.exports.useState(""),[S,k]=n.exports.useState(""),[O,D]=n.exports.useState(""),[P,F]=n.exports.useState(0),[I,V]=n.exports.useState(""),[H,M]=n.exports.useState(""),[T,z]=n.exports.useState(!1),[U,R]=n.exports.useState(null),[j,_]=n.exports.useState(null),[i,y]=n.exports.useState(null),[W,Y]=n.exports.useState(null),[Z,ee]=n.exports.useState(null),[te,ae]=n.exports.useState(void 0),[ne,Ee]=n.exports.useState(void 0),[Q,oe]=n.exports.useState(void 0),q=G.useRef(null),[Ce,K]=n.exports.useState(!1),ie=c(o=>o.category.categories),L=c(o=>o.category.status),[ve,De]=n.exports.useState(),le=c(o=>o.nationality.nationalities),X=c(o=>o.nationality.status),[ye,be]=n.exports.useState(),se=c(o=>o.producer.producers),$=c(o=>o.producer.status),[Ae,Se]=n.exports.useState(),re=c(o=>o.director.directors),b=c(o=>o.director.status),[ke,Oe]=n.exports.useState(),ce=c(o=>o.actor.result),Fe=c(o=>o.actor.status),[de,Pe]=n.exports.useState();n.exports.useEffect(()=>{m==="added"?(C("Th\xEAm th\xE0nh c\xF4ng"),E(!0),A(Ke())):m==="failed"&&(C(g),E(!0))},[A,m]);const J=n.exports.useMemo(()=>()=>{K(!0);const o=[...ie].map(d=>({key:d.id,text:d.name,value:d.id}));De(o);const l=[...se].map(d=>({key:d.id,text:d.name,value:d.id}));Se(l);const ge=[...re].map(d=>({key:d.id,text:d.name,value:d.id}));Oe(ge);const t=[...le].map(d=>({key:d.id,text:d.name,value:d.id}));be(t);const s=[...ce].map(d=>({key:d.id,text:d.name,value:d.id}));Pe(s)},[ie,se,re,le,ce]),ue=()=>{K(!1)},Ne=()=>{K(!1)},we=()=>{A(et({name:O,alias:S,duration:P,releaseDate:new Date(I).toISOString(),content:H,status:T,imageBackground:j,imagePreview:U,videoTrailer:i,producer:W,nationality:Z,categoryId:Q,directorId:ne,actorId:te,token:p})),console.log(O,P,I,H,T,U,j,i,te,ne,W,Z,Q,H)},Be=(o,l)=>{console.log(l,"data category dropdown change"),oe(l.value)},Ie=(o,l)=>{ae(l.value)},He=(o,l)=>{Y(l.value)},Me=(o,l)=>{ee(l.value)},Te=(o,l)=>{Ee(l.value)},he=(o,l)=>{l!=="clickaway"&&E(!1)};return h(me,{children:[h(N,{icon:!0,color:"blue",onClick:J,labelPosition:"right",children:[e(Le,{name:"add"})," Th\xEAm m\u1EDBi"]}),h(Ve,{fullScreen:v,open:Ce,onClose:ue,"aria-labelledby":"alert-dialog-title","aria-describedby":"alert-dialog-description",children:[e(ze,{id:"alert-dialog-title",className:"text-3xl font-semibold",children:"Th\xEAm m\u1EDBi phim"}),h(Ue,{children:[e(Re,{id:"alert-dialog-description",children:"Khi th\xEAm m\u1EDBi b\u1ED9 phim s\u1EBD th\xEAm m\u1EDBi"}),e(Xe,{className:"pt-5",children:h(r,{size:"small",children:[e(r.Field,{children:e(x,{icon:"id badge",iconPosition:"left",label:{tag:!0,content:"T\xEAn"},labelPosition:"right",placeholder:"Nh\u1EADp t\xEAn",onChange:(o,l)=>{D(l.value),k(yt(l.value))}})}),e(r.Field,{children:e(x,{icon:"amilia",iconPosition:"left",label:{tag:!0,content:"B\xED danh (Alias)"},labelPosition:"right",placeholder:"Nh\u1EADp b\xED danh",value:S,onChange:(o,l)=>{k(l.value)}})}),e(r.Field,{children:e(x,{icon:"time",iconPosition:"left",label:{tag:!0,content:"Th\u1EDDi l\u01B0\u1EE3ng (ph\xFAt)"},labelPosition:"right",placeholder:"Nh\u1EADp th\u1EDDi l\u01B0\u1EE3ng",type:"number",value:P,onChange:(o,l)=>{F(Number.parseInt(l.value))}})}),e(r.Field,{children:e(x,{icon:"calendar alternate",iconPosition:"left",label:{tag:!0,content:"Ng\xE0y c\xF4ng chi\u1EBFu"},labelPosition:"right",placeholder:"Ng\xE0y c\xF4ng chi\u1EBFu",type:"date",value:I,onChange:(o,l)=>{V(l.value)}})}),e(r.Field,{children:e(x,{icon:"file image",iconPosition:"left",label:{tag:!0,content:"H\xECnh review"},labelPosition:"right",placeholder:"H\xECnh review",type:"file",accept:Ge,onChange:(o,l)=>{R(o.target.files[0]),console.log(o.target.files[0],"imgage")}})}),e(r.Field,{children:e(x,{icon:"file image",iconPosition:"left",label:{tag:!0,content:"H\xECnh background"},labelPosition:"right",placeholder:"H\xECnh background",accept:Ge,type:"file",onChange:(o,l)=>_(o.target.files[0])})}),e(r.Field,{children:e(x,{icon:"file video",iconPosition:"left",label:{tag:!0,content:"Video trailer"},labelPosition:"right",placeholder:"Video trailer",type:"file",accept:bt,onChange:(o,l)=>y(o.target.files[0])})}),e(r.Field,{children:e(f,{loading:L==="loading",placeholder:"Ch\u1ECDn danh m\u1EE5c phim",multiple:!0,selection:!0,search:!0,dataOption:ve,onSelectChange:Be})}),e(r.Field,{children:e(f,{loading:Fe==="loading",placeholder:"Ch\u1ECDn di\u1EC5n vi\xEAn",multiple:!0,selection:!0,search:!0,dataOption:de,onSelectChange:Ie})}),e(r.Field,{children:e(f,{loading:b==="loading",placeholder:"Ch\u1ECDn \u0111\u1EA1o di\u1EC5n",multiple:!0,selection:!0,search:!0,dataOption:ke,onSelectChange:Te})}),e(r.Field,{children:e(f,{loading:$==="loading",placeholder:"Ch\u1ECDn nh\xE0 s\u1EA3n xu\u1EA5t",selection:!0,search:!0,dataOption:Ae,onSelectChange:He})}),e(r.Field,{children:e(f,{loading:X==="loading",placeholder:"Ch\u1ECDn qu\u1ED1c gia",selection:!0,search:!0,dataOption:ye,onSelectChange:Me})}),e(r.Field,{children:e(f,{placeholder:"Tr\u1EA1ng th\xE1i",selection:!0,dataOption:At,onSelectChange:(o,l)=>z(l.value)})}),e(r.Field,{children:e(We,{apiKey:"yillg49dt4io6vjxyvs8k26ldhgtxqnmurmteil8v2j6mljb",onInit:(o,l)=>q.current=l,initialValue:"<p>Nh\u1EADp n\u1ED9i dung phim.</p>",init:{height:500,menubar:!1,plugins:["advlist autolink lists link image charmap print preview anchor","searchreplace visualblocks code fullscreen","insertdatetime media table paste code help wordcount"],toolbar:"undo redo | formatselect | bold italic backcolor | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | removeformat | help",content_style:"body { font-family:Helvetica,Arial,sans-serif; font-size:14px }"},onEditorChange:o=>{M(o)}})})]})})]}),h(je,{children:[e(N,{color:"blue",onClick:we,children:"X\xE1c nh\u1EADn l\u01B0u"}),e(N,{color:"red",onClick:Ne,autoFocus:!0,children:"Hu\u1EF7 b\u1ECF l\u01B0u"})]})]}),e(_e,{open:w,anchorOrigin:{horizontal:"center",vertical:"top"},autoHideDuration:6e3,onClose:he,children:e(fe,{onClose:he,severity:g?"error":m==="added"?"success":void 0,sx:{width:"100%"},children:B})})]})},kt=({id:a})=>{const A=xe(),[v,p]=G.useState(!1),m=localStorage.getItem("token"),g=()=>{a.length===0?C(!0):p(!0)},w=()=>{p(!1)},E=()=>{p(!1)},[B,C]=G.useState(!1),S=(O,D)=>{D!=="clickaway"&&C(!1)};return h(me,{children:[h(N,{icon:!0,color:"red",onClick:g,labelPosition:"right",children:[e(Le,{name:"delete"})," Xo\xE1 nhi\u1EC1u"]}),h(Ve,{open:v,onClose:w,"aria-labelledby":"alert-dialog-title","aria-describedby":"alert-dialog-description",children:[e(ze,{id:"alert-dialog-title",className:"text-xl font-bold",children:"B\u1EA1n c\xF3 th\u1EF1c s\u1EF1 mu\u1ED1n xo\xE1?"}),e(Ue,{children:e(Re,{id:"alert-dialog-description",className:"text-lg",children:"H\xE0ng b\u1EA1n mu\u1ED1n xo\xE1 l\xE0"})}),h(je,{children:[e(N,{color:"red",onClick:E,children:"Hu\u1EF7 b\u1ECF xo\xE1"}),e(N,{color:"blue",onClick:()=>{a.length>0&&(A(tt({id:a,token:m})),p(!1))},autoFocus:!0,children:"X\xE1c nh\u1EADn xo\xE1"})]})]}),e(_e,{anchorOrigin:{horizontal:"center",vertical:"top"},open:B,autoHideDuration:6e3,onClose:S,children:e(fe,{onClose:S,variant:"filled",severity:"error",sx:{width:"100%"},children:"Vui l\xF2ng ch\u1ECDn d\xF2ng c\u1EA7n xo\xE1."})})]})},Qe=".jpg, .png, image/*",Ot="video/*",Ft=[{key:1,text:"Phim \u0111ang chi\u1EBFu",value:!0},{key:2,text:"Phim s\u1EAFp chi\u1EBFu",value:!1}],Pt=a=>{var l,ge;const A=qe(),v=xe(),p=Je(A.breakpoints.down("md")),m=c(t=>t.movie.error),g=c(t=>t.movie.status),w=localStorage.getItem("token"),[E,B]=n.exports.useState(""),[C,S]=n.exports.useState(a.name),[k,O]=n.exports.useState(a.duration),[D,P]=n.exports.useState($e(a.releaseDate).toISOString().substring(0,10)),[F,I]=n.exports.useState(a.content),[V,H]=n.exports.useState(!1),[M,T]=n.exports.useState(null),[z,U]=n.exports.useState(null),[R,j]=n.exports.useState(null),[_,i]=n.exports.useState(null),[y,W]=n.exports.useState(null),[Y,Z]=n.exports.useState(void 0),[ee,te]=n.exports.useState(void 0),[ae,ne]=n.exports.useState(void 0),Ee=G.useRef(null),[Q,oe]=n.exports.useState(a.isOpen),q=c(t=>t.category.categories),Ce=c(t=>t.category.status),[K,ie]=n.exports.useState([]),L=c(t=>t.nationality.nationalities),ve=c(t=>t.nationality.status),[De,le]=n.exports.useState([]),X=c(t=>t.producer.producers),ye=c(t=>t.producer.status),[be,se]=n.exports.useState([]),$=c(t=>t.director.directors),Ae=c(t=>t.director.status),[Se,re]=n.exports.useState([]),b=c(t=>t.actor.result),ke=c(t=>t.actor.status),[Oe,ce]=n.exports.useState([]),[Fe,de]=n.exports.useState(""),[Pe,J]=G.useState(!1);n.exports.useCallback(async()=>await at(),[]);const ue=n.exports.useMemo(()=>()=>{const t=[...b].map(u=>({key:u.id,text:u.name,value:u.id}));ce(t);const s=[...q].map(u=>({key:u.id,text:u.name,value:u.id}));ie(s);const d=[...X].map(u=>({key:u.id,text:u.name,value:u.id}));se(d);const Ye=[...$].map(u=>({key:u.id,text:u.name,value:u.id}));re(Ye);const Ze=[...L].map(u=>({key:u.id,text:u.name,value:u.id}));le(Ze)},[]);n.exports.useEffect(()=>{Q&&ue(),g==="updated"?(de("C\u1EADp nh\u1EADp th\xE0nh c\xF4ng"),J(!0),v(Ke())):g==="failed"&&(de(m),J(!0)),console.log(a.producer,"inside useeffect")},[g,v,ue]);const Ne=()=>{oe(!1),a.setOpenUpdateMovie(!1)},we=()=>{oe(!1),a.setOpenUpdateMovie(!1)},Be=()=>{console.log(a.actors.split(", "),"actors props"),console.log(b&&b.length>0&&(b==null?void 0:b.filter(t=>a.actors.split(", ").indexOf(t.name)>-1).map(t=>t.id)),"hihi"),v(nt({id:a.id,name:C,alias:E,duration:k,releaseDate:new Date(D).toISOString(),content:F,status:V,imageBackground:z,imagePreview:M,videoTrailer:R,producer:_,nationality:y,categoryId:ae,directorId:ee,actorId:Y,token:w})),console.log(C,k,D,F,V,M,z,R,Y,ee,_,y,ae,F)},Ie=(t,s)=>{console.log(s,"data category dropdown change"),ne(s.value)},He=(t,s)=>{Z(s.value)},Me=(t,s)=>{i(s.value)},Te=(t,s)=>{W(s.value)},he=(t,s)=>{te(s.value)},o=(t,s)=>{s!=="clickaway"&&J(!1)};return h(me,{children:[h(Ve,{fullScreen:p,open:Q,onClose:Ne,"aria-labelledby":"alert-dialog-title","aria-describedby":"alert-dialog-description",children:[h(ze,{id:"alert-dialog-title",className:"text-3xl font-semibold",children:['C\u1EADp nh\u1EADt phim "',e("span",{style:{color:"#f97316"},children:a.name}),'"']}),h(Ue,{children:[e(Re,{id:"alert-dialog-description",children:"Khi c\u1EADp nh\u1EADt b\u1ED9 phim s\u1EBD c\u1EADp nh\u1EADt"}),e(Xe,{className:"pt-5",children:h(r,{size:"small",children:[e(r.Field,{children:e(x,{icon:"id badge",iconPosition:"left",label:{tag:!0,content:"T\xEAn"},labelPosition:"right",placeholder:"Nh\u1EADp t\xEAn",value:C,onChange:(t,s)=>{S(s.value),B(dt(s.value))}})}),e(r.Field,{children:e(x,{icon:"amilia",iconPosition:"left",label:{tag:!0,content:"B\xED danh (Alias)"},labelPosition:"right",placeholder:"Nh\u1EADp b\xED danh",value:E,onChange:(t,s)=>{B(s.value)}})}),e(r.Field,{children:e(x,{icon:"time",iconPosition:"left",label:{tag:!0,content:"Th\u1EDDi l\u01B0\u1EE3ng (ph\xFAt)"},labelPosition:"right",placeholder:"Nh\u1EADp th\u1EDDi l\u01B0\u1EE3ng",type:"number",value:k,onChange:(t,s)=>{O(Number.parseInt(s.value))}})}),e(r.Field,{children:e(x,{icon:"calendar alternate",iconPosition:"left",label:{tag:!0,content:"Ng\xE0y c\xF4ng chi\u1EBFu"},labelPosition:"right",placeholder:"Ng\xE0y c\xF4ng chi\u1EBFu",type:"date",value:D,onChange:(t,s)=>{P(s.value)}})}),e(r.Field,{children:e(x,{icon:"file image",iconPosition:"left",label:{tag:!0,content:"H\xECnh review"},labelPosition:"right",placeholder:"H\xECnh review",type:"file",accept:Qe,onChange:(t,s)=>{T(t.target.files[0]),console.log(t.target.files[0],"imgage")}})}),e(r.Field,{children:e(x,{icon:"file image",iconPosition:"left",label:{tag:!0,content:"H\xECnh background"},labelPosition:"right",placeholder:"H\xECnh background",accept:Qe,type:"file",onChange:(t,s)=>U(t.target.files[0])})}),e(r.Field,{children:e(x,{icon:"file video",iconPosition:"left",label:{tag:!0,content:"Video trailer"},labelPosition:"right",placeholder:"Video trailer",type:"file",accept:Ot,onChange:(t,s)=>j(t.target.files[0])})}),e(r.Field,{children:e(f,{loading:Ce==="loading",placeholder:"Ch\u1ECDn danh m\u1EE5c phim",multiple:!0,selection:!0,search:!0,dataOption:K,defaultValue:q&&q.filter(t=>a.categories.split(", ").indexOf(t.name)>-1).map(t=>t.id),onSelectChange:Ie})}),e(r.Field,{children:e(f,{loading:ke==="loading",placeholder:"Ch\u1ECDn di\u1EC5n vi\xEAn",multiple:!0,selection:!0,search:!0,dataOption:Oe,defaultValue:b&&b.filter(t=>a.actors.split(", ").indexOf(t.name)>-1).map(t=>t.id),onSelectChange:He})}),e(r.Field,{children:e(f,{loading:Ae==="loading",placeholder:"Ch\u1ECDn \u0111\u1EA1o di\u1EC5n",multiple:!0,selection:!0,search:!0,dataOption:Se,defaultValue:$&&$.filter(t=>a.directors.split(", ").indexOf(t.name)>-1).map(t=>t.id),onSelectChange:he})}),e(r.Field,{children:e(f,{loading:ye==="loading",placeholder:"Ch\u1ECDn nh\xE0 s\u1EA3n xu\u1EA5t",selection:!0,search:!0,dataOption:be,defaultValue:X&&((l=X.find(t=>a.producer===t.name))==null?void 0:l.id),onSelectChange:Me})}),e(r.Field,{children:e(f,{loading:ve==="loading",placeholder:"Ch\u1ECDn qu\u1ED1c gia",selection:!0,search:!0,dataOption:De,defaultValue:L&&((ge=L.find(t=>a.nationality===t.name))==null?void 0:ge.id),onSelectChange:Te})}),e(r.Field,{children:e(f,{placeholder:"Tr\u1EA1ng th\xE1i",selection:!0,dataOption:Ft,defaultValue:a.status,onSelectChange:(t,s)=>H(s.value)})}),e(r.Field,{children:e(We,{apiKey:"yillg49dt4io6vjxyvs8k26ldhgtxqnmurmteil8v2j6mljb",onInit:(t,s)=>Ee.current=s,initialValue:F||"<p>Nh\u1EADp n\u1ED9i dung phim.</p>",init:{height:500,menubar:!1,plugins:["advlist autolink lists link image charmap print preview anchor","searchreplace visualblocks code fullscreen","insertdatetime media table paste code help wordcount"],toolbar:"undo redo | formatselect | bold italic backcolor | alignleft aligncenter alignright alignjustify | bullist numlist outdent indent | removeformat | help",content_style:"body { font-family:Helvetica,Arial,sans-serif; font-size:14px }"},onEditorChange:t=>{I(t)}})})]})})]}),h(je,{children:[e(N,{color:"blue",onClick:Be,children:"X\xE1c nh\u1EADn l\u01B0u"}),e(N,{color:"red",onClick:we,autoFocus:!0,children:"Hu\u1EF7 b\u1ECF l\u01B0u"})]})]}),e(_e,{open:Pe,anchorOrigin:{horizontal:"center",vertical:"top"},autoHideDuration:6e3,onClose:o,children:e(fe,{onClose:o,severity:m?"error":g==="updated"?"success":void 0,sx:{width:"100%"},children:Fe})})]})},Nt=[{field:"id",headerName:"ID",width:45},{field:"imageBackground",headerName:"H\xECnh",width:53,renderCell:a=>e(vt,{src:a.value,variant:"rounded"})},{field:"name",headerName:"T\xEAn phim",flex:1},{field:"duration",headerName:"Th\u1EDDi l\u01B0\u1EE3ng phim",width:85},{field:"releaseDate",headerName:"Ng\xE0y c\xF4ng chi\u1EBFu",type:"dateTime",flex:1,renderCell:a=>$e(a.value).format("DD/MM/yyyy")},{field:"nationality",headerName:"Qu\u1ED1c gia",type:"string",flex:1},{field:"categories",headerName:"Danh m\u1EE5c phim",type:"string",flex:1},{field:"actors",headerName:"Di\u1EC5n vi\xEAn",type:"string",flex:1},{field:"directors",headerName:"\u0110\u1EA1o di\u1EC5n",type:"string",flex:1},{field:"producer",headerName:"Nh\xE0 s\u1EA3n xu\u1EA5t",type:"string",flex:1}],wt=[{key:"all",value:"all",text:"T\u1EA5t c\u1EA3"},{key:"en",value:"en",text:"M\u1EF9",flag:"us"},{key:"au",value:"au",text:"\xDAc",flag:"au"},{key:"zh",value:"zh",text:"Trung Qu\u1ED1c",flag:"cn"},{key:"ko",value:"ko",text:"H\xE0n Qu\u1ED1c",flag:"kr"},{key:"vi",value:"vi",text:"Vi\u1EC7t Nam",flag:"vn"}];function Bt(a){return e(me,{children:e(Dt,{sx:{color:"#fafafa","&.Mui-checked":{color:"#fafafa"}},...a})})}const Mt=()=>{const a=xe(),{status:A,movies:v,total:p,error:m}=c(i=>i.movie),[g,w]=n.exports.useState(1),[E,B]=n.exports.useState(0),[C,S]=n.exports.useState("all"),[k,O]=n.exports.useState(!1),[D,P]=n.exports.useState(p||0),[F,I]=n.exports.useState([]),[V,H]=n.exports.useState(),[M,T]=n.exports.useState(!1);n.exports.useEffect(()=>{v.length<=0&&a(pe({PageIndex:E,PageSize:g})),P(i=>p!==void 0?p:i),m&&O(!0),a(ot()),a(it()),a(lt()),a(st()),a(rt()),console.log(D,"      ",p,"rowCountState")},[a,p,P,m,O]);const z=n.exports.useMemo(()=>i=>{console.log(i,"page index"),a(pe({PageIndex:i,PageSize:g,Nationality:C}))},[a,g]),U=i=>{T(i)},R=i=>{T(!0),H(i.row)},j=(i,y)=>{I(i),console.log(i,y,"seletion data grid")},_=(i,y)=>{S(y.value),console.log(y.value,"data dropdown"),a(pe({PageIndex:E,PageSize:g,Nationality:y.value}))};return h(ut,{title:"Qu\u1EA3n l\xFD Phim",children:[e("div",{children:e(ht,{in:k,children:e(fe,{variant:"filled",severity:"error",action:e(gt,{"aria-label":"close",color:"inherit",size:"small",onClick:()=>{O(!1),a(ct())},children:e(pt,{fontSize:"inherit"})}),sx:{mb:2},children:m})})}),h("div",{className:"py-2",children:[e(St,{}),M&&e(Pt,{...V,setOpenUpdateMovie:U,isOpen:M}),e(kt,{id:F})]}),e(xt,{elevation:1,square:!0,className:"p-5 my-1",children:e("div",{className:"flex",children:h("span",{className:"font-semibold",children:["Qu\u1ED1c gia"," ",e(f,{inline:!0,dataOption:wt,onSelectChange:_})]})})}),e("div",{style:{height:400,width:"100%"},children:e(mt,{sx:{".MuiDataGrid-columnHeader":{backgroundColor:"#333",color:"#fff"}},loading:A==="loading",rows:v,columns:Nt,pageSize:g,rowsPerPageOptions:[1,3,5,10,20,50,100],onPageSizeChange:i=>{w(i),a(pe({PageIndex:E,PageSize:i,Nationality:C}))},pagination:!0,paginationMode:"server",checkboxSelection:!0,onPageChange:z,rowCount:D,onSelectionModelChange:j,components:{BaseCheckbox:Bt,Toolbar:ft,LoadingOverlay:Et},localeText:Ct,getCellClassName:i=>i.field==="imageBackground"||i.field==="id"||i.field==="name"||i.field==="duration"||i.field==="releaseDate"||i.field==="nationality"||i.field==="producer"||i.field==="directors"||i.field==="actors"||i.field==="categories"||i.value==null?"":i.row.status===!1?"bg-blue-400":"bg-rose-400",onRowClick:R})})]})};export{Mt as default};