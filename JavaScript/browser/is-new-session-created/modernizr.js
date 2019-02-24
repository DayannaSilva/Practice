/*! modernizr 3.6.0 (Custom Build) | MIT *
 * https://modernizr.com/download/?-cookies-setclasses !*/
! function(e, n, o) {
    function s(e, n) {
        return typeof e === n
    }

    function a() {
        var e, n, o, a, t, r, f;
        for (var l in c)
            if (c.hasOwnProperty(l)) {
                if (e = [], n = c[l], n.name && (e.push(n.name.toLowerCase()), n.options && n.options.aliases && n.options.aliases.length))
                    for (o = 0; o < n.options.aliases.length; o++) e.push(n.options.aliases[o].toLowerCase());
                for (a = s(n.fn, "function") ? n.fn() : n.fn, t = 0; t < e.length; t++) r = e[t], f = r.split("."), 1 === f.length ? Modernizr[f[0]] = a : (!Modernizr[f[0]] || Modernizr[f[0]] instanceof Boolean || (Modernizr[f[0]] = new Boolean(Modernizr[f[0]])), Modernizr[f[0]][f[1]] = a), i.push((a ? "" : "no-") + f.join("-"))
            }
    }

    function t(e) {
        var n = f.className,
            o = Modernizr._config.classPrefix || "";
        if (l && (n = n.baseVal), Modernizr._config.enableJSClass) {
            var s = new RegExp("(^|\\s)" + o + "no-js(\\s|$)");
            n = n.replace(s, "$1" + o + "js$2")
        }
        Modernizr._config.enableClasses && (n += " " + o + e.join(" " + o), l ? f.className.baseVal = n : f.className = n)
    }
    var i = [],
        c = [],
        r = {
            _version: "3.6.0",
            _config: {
                classPrefix: "",
                enableClasses: !0,
                enableJSClass: !0,
                usePrefixes: !0
            },
            _q: [],
            on: function(e, n) {
                var o = this;
                setTimeout(function() {
                    n(o[e])
                }, 0)
            },
            addTest: function(e, n, o) {
                c.push({
                    name: e,
                    fn: n,
                    options: o
                })
            },
            addAsyncTest: function(e) {
                c.push({
                    name: null,
                    fn: e
                })
            }
        },
        Modernizr = function() {};
    Modernizr.prototype = r, Modernizr = new Modernizr, Modernizr.addTest("cookies", function() {
        try {
            n.cookie = "cookietest=1";
            var e = -1 != n.cookie.indexOf("cookietest=");
            return n.cookie = "cookietest=1; expires=Thu, 01-Jan-1970 00:00:01 GMT", e
        } catch (o) {
            return !1
        }
    });
    var f = n.documentElement,
        l = "svg" === f.nodeName.toLowerCase();
    a(), t(i), delete r.addTest, delete r.addAsyncTest;
    for (var u = 0; u < Modernizr._q.length; u++) Modernizr._q[u]();
    e.Modernizr = Modernizr
}(window, document);