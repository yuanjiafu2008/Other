(function(f,c){var b=1,e=function(){},j="<%=name%>-<%=id%>",h=(function(){var n={},o=0,m="GMUWidget"+(+new Date());return function(s,r,t){var p=s[m]||(s[m]=++o),q=n[p]||(n[p]={});!f.isUndefined(t)&&(q[r]=t);f.isNull(t)&&delete q[r];return q[r]}})();f.ui=f.ui||{version:"2.0.5",guid:g,define:function(n,p,o){if(o){p.inherit=o}var m=f.ui[n]=d(function(r,q){var s=k(m.prototype,{_id:f.parseTpl(j,{name:n,id:g()})});s._createWidget.call(s,r,q,m.plugins);return s},p);return i(n,m)},isWidget:function(n,m){return n instanceof (m===c?l:f.ui[m]||e)}};function g(){return b++}function k(m,n){var o={};Object.create?o=Object.create(m):o.__proto__=m;return f.extend(o,n||{})}function d(m,n){if(n){a(m,n);f.extend(m.prototype,n)}return f.extend(m,{plugins:[],register:function(o){if(f.isObject(o)){f.extend(this.prototype,o);return}this.plugins.push(o)}})}function a(m,p){var n=p.inherit||l,o=n.prototype,q;q=m.prototype=k(o,{$factory:m,$super:function(r){var s=o[r];return f.isFunction(s)?s.apply(this,f.slice(arguments,1)):s}});q._data=f.extend({},o._data,p._data);delete p._data;return m}function i(m){f.fn[m]=function(p){var o,q,n=f.slice(arguments,1);f.each(this,function(r,s){q=h(s,m)||f.ui[m](s,f.extend(f.isPlainObject(p)?p:{},{setup:true}));if(f.isString(p)){if(!f.isFunction(q[p])&&p!=="this"){throw new Error(m+"\u7ec4\u4ef6\u6ca1\u6709\u6b64\u65b9\u6cd5")}o=f.isFunction(q[p])?q[p].apply(q,n):c}if(o!==c&&o!==q||p==="this"&&(o=q)){return false}o=c});return o!==c?o:this}}var l=function(){};f.extend(l.prototype,{_data:{status:true},data:function(m,o){var n=this._data;if(f.isObject(m)){return f.extend(n,m)}else{return !f.isUndefined(o)?n[m]=o:n[m]}},_createWidget:function(o,q,m){if(f.isObject(o)){q=o||{};o=c}var r=f.extend({},this._data,q);f.extend(this,{_el:o?f(o):c,_data:r});var p=this;f.each(m,function(u,v){var s=v.apply(p);if(s&&f.isPlainObject(s)){var t=p._data.disablePlugin;if(!t||f.isString(t)&&!~t.indexOf(s.pluginName)){delete s.pluginName;f.each(s,function(w,y){var x;if((x=p[w])&&f.isFunction(y)){p[w]=function(){p[w+"Org"]=x;return y.apply(p,arguments)}}else{p[w]=y}})}}});if(r.setup){this._setup(o&&o.getAttribute("data-mode"))}else{this._create()}this._init();var p=this,n=this.trigger("init").root();n.on("tap",function(s){(s.bubblesList||(s.bubblesList=[])).push(p)});h(n[0],p._id.split("-")[0],p)},_create:function(){},_setup:function(m){},root:function(m){return this._el=m||this._el},id:function(m){return this._id=m||this._id},destroy:function(){var n=this,m;m=this.trigger("destroy").off().root();m.find("*").off();h(m[0],n._id.split("-")[0],null);m.off().remove();this.__proto__=null;f.each(this,function(o){delete n[o]})},on:function(m,n){this.root().on(m,f.proxy(n,this));return this},off:function(m,n){this.root().off(m,n);return this},trigger:function(n,o){n=f.isString(n)?f.Event(n):n;var p=this.data(n.type),m;if(p&&f.isFunction(p)){n.data=o;m=p.apply(this,[n].concat(o));if(m===false||n.defaultPrevented){return this}}this.root().trigger(n,o);return this}})})(Zepto);