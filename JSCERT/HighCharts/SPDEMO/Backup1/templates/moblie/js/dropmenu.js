(function(d,f){var a={arrow:'<span class="ui-dropmenu-arrow"></span>',items:'<ul class="ui-dropmenu-items"><% for(var i=0, length = items.length; i<length; i++){ var item = items[i]; %><li class="<%=item.icon&&item.text?\'ui-icontext\':item.icon?\'ui-icononly\':\'ui-textonly\'%>"><a<% if(item.href){ %> href="<%=item.href%>"<% } %>><% if(item.icon){ %><span class="ui-icon ui-icon-<%=item.icon%>"></span><% } %><%=item.text%></a></li><% } %></ul>'},h=/\bui\-icon\-(\w+)\b/ig,e=/^(?:body|html)$/i,g=100,c={up:{x:0,y:1},down:{x:0,y:-1}},b={left:{left:"25%",right:"auto"},center:{left:"50%",right:"auto"},right:{left:"75%",right:"auto"}};d.ui.define("dropmenu",{_data:{btn:null,align:"center",width:null,height:null,offset:null,pos:"down",direction:"vertical",arrow:true,arrowPos:null,autoClose:true,items:null,itemClick:null,cacheParentOffset:true},_prepareDom:function(n,m){var l=this,k,j=l._el,i;switch(n){case"fullsetup":case"setup":m._arrow=l._findElement(".ui-dropmenu-arrow");m._arrow||m.arrow&&(m._arrow=d(a.arrow).prependTo(j));m._items=l._el.find("ul").first();if(m._items){i=[];m._items.addClass("ui-dropmenu-items").children().each(function(){var r=d(this),p=d("a",this).first(),o=d(".ui-icon",this),q;i.push(q={text:p.text(),icon:o.length&&o.attr("class").match(h)&&RegExp.$1});r.addClass(q.icon&&q.text?"ui-icontext":q.icon?"ui-icononly":"ui-textonly")});m.items=i}else{m._items=d(d.parseTpl(a.items,{items:m.items||[]})).appendTo(j)}break;default:k=m.arrow?a.arrow:"";k+=d.parseTpl(a.items,{items:m.items||[]});j.append(k);m._arrow=l._findElement(".ui-dropmenu-arrow");m._items=l._findElement(".ui-dropmenu-items");m.container=m.container||"body"}m.container&&j.appendTo(m.container)},_findElement:function(i){var j=this._el.find(i);return j.length?j:null},_create:function(){var i=this,j=i._data;i._el=i._el||d("<div></div>");i._prepareDom("create",j)},_setup:function(k){var i=this,j=i._data;i._prepareDom(k?"fullsetup":"setup",j)},_init:function(){var k=this,l=k._data,j=k.root(),i=d.proxy(k._eventHandler,k);j.addClass(k._prepareClassName()).css({width:l.width||"",height:l.height||""});d(".ui-dropmenu-items li a",j).highlight("ui-state-hover");j.on("click",i).highlight();d(window).on("ortchange",i);l.btn&&k.bindButton(d.ui.isWidget(l.btn)?l.btn.root():l.btn)},_prepareClassName:function(){var j=this._data,i="ui-dropmenu";j.direction=="horizontal"&&(i+=" ui-horizontal");return i},bindButton:function(i){var j=this,k=j._data;k._btn&&k._btn.off("click.dropmenu");k._btn=d(i).on("click",d.proxy(j._eventHandler,j));return j},_getParentOffset:function(){var k=this._el,j=k.offsetParent(),i=e.test(j[0].nodeName)?{top:0,left:0}:j.offset();i.top+=parseFloat(d(j[0]).css("border-top-width"))||0;i.left+=parseFloat(d(j[0]).css("border-left-width"))||0;return i},_isInRange:function(l,j,k,i){return !(l<k||l+j>k+i)},__caculate:function(j,i,k,l){switch(j){case"up":return i.top-l;case"down":return i.top+i.height;case"left":return i.left;case"center":return i.left+i.width/2-k/2;default:return i.left+i.width-k}},_caculate:function(r){var u,k,m=this._data,l,t,q,v,o,n,s,j,p,i=m._parentOffset;!m._btn?(m._btn=d(r)):m._btn.add(r);if(!m._btn.length){throw new Error("\u8c03\u7528dropmenu->show\u9519\u8bef\uff0c\u9700\u8981\u6307\u5b9a\u4e00\u4e2aElement\u4e0e\u4e4b\u5173\u8054!")}o=m._btn.offset();n=(v=this._el).width();s=v.height();t=m.pos;q=m.align;if(t=="auto"){j=window.pageYOffset;p=window.innerHeight;u=this.__caculate(t="down",o,n,s);if(!this._isInRange(u,s,j,p)){u=this.__caculate(t="up",o,n,s);this._isInRange(u,s,j,p)||(u=this.__caculate(t="down",o,n,s))}}else{u=this.__caculate(m.pos,o,n,s)}if(q=="auto"){j=0;p=window.innerWidth;k=this.__caculate(q="center",o,n,s);if(!this._isInRange(k,n,j,p)){k=this.__caculate(q="left",o,n,s);this._isInRange(k,n,j,p)||(k=this.__caculate(q="right",o,n,s))}}else{k=this.__caculate(m.align,o,n,s)}v[t=="up"?"addClass":"removeClass"]("ui-dropmenu-pos-up").removeClass("ui-alignleft ui-aligncenter ui-alignright").addClass(q=="left"?"ui-alignleft":q=="right"?"ui-alignright":"ui-aligncenter");l=m.offset||c[t=="up"?"up":"down"];m._arrow&&m._arrow.css(m.arrowPos||b[q]);return{top:u+l.y-i.top,left:k+l.x-i.left}},show:function(k){var i=this,j=this._data;j._parentOffset=j.cacheParentOffset?j._parentOffset||this._getParentOffset():this._getParentOffset();j.autoClose&&d(document).on("click."+this.id(),function(l){i._isFromSelf(l.target)||i.hide()});this._el.css(this._caculate(j._actBtn=k||j._actBtn)).css("zIndex",g++);j._isShow=true;return this},_eventHandler:function(n){var o=this,m,l=this._data,j,k,q,i,p;switch(n.type){case"ortchange":l._parentOffset=this._getParentOffset();l._isShow&&o._el.css(o._caculate(l._actBtn));break;default:j=o._el.get(0);if((m=d(n.target).closest(".ui-dropmenu-items li",j))&&m.length){q=d.Event("itemClick");k=l.items[m.index()];i=k&&k.click&&k.click.apply(o,[q,k,m[0]])===false;(i=i||q.defaultPrevented)||o.trigger(q,[k,m[0]]);(i||q.defaultPrevented)&&n.preventDefault()}else{o.toggle()}}},_isFromSelf:function(k){var i=false,j=this._data;d.each(this._el.add(j._btn),function(){if(this==k||d.contains(this,k)){i=true;return false}});return i},hide:function(){var i=this._data;i._isShow&&this.root().css("top","-99999px");i.autoClose&&d(document).off("click."+this.id());i._isShow=false;return this},toggle:function(){return this[this._data._isShow?"hide":"show"].apply(this,arguments)},destroy:function(){var j=this._data,i=this._eventHandler;j._btn&&j._btn.off("click",i);d(".ui-dropmenu-items li a",this._el).highlight();j.autoClose&&d(document).off("click."+this.id());d(window).off("ortchange",i);return this.$super("destroy")}})})(Zepto);