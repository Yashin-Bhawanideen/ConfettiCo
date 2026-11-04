(function () {
  var toggle = document.getElementById('navToggle');
  var nav = document.getElementById('mainNav');
  if (toggle && nav) {
    toggle.addEventListener('click', function () {
      var open = nav.classList.toggle('open');
      toggle.setAttribute('aria-expanded', open ? 'true' : 'false');
      toggle.classList.toggle('open', open);
    });
  }

  // One confetti burst on the "thank you" page
  var host = document.querySelector('[data-confetti]');
  var reduce = window.matchMedia && window.matchMedia('(prefers-reduced-motion: reduce)').matches;
  if (host && !reduce && host.animate) {
    var colors = ['#ff3d8b', '#ffb800', '#19b5a5', '#7a5cff', '#3d9bff', '#ff7a2f'];
    for (var i = 0; i < 70; i++) {
      var p = document.createElement('i');
      var size = 8 + Math.random() * 8;
      p.style.cssText = 'position:fixed;top:-20px;left:' + (Math.random() * 100) + 'vw;width:' + size + 'px;height:' + (size * 0.5) +
        'px;background:' + colors[i % colors.length] + ';border-radius:2px;z-index:90;pointer-events:none;';
      host.appendChild(p);
      var drift = (Math.random() - 0.5) * 240;
      p.animate([
        { transform: 'translate(0,0) rotate(0deg)', opacity: 1 },
        { transform: 'translate(' + drift + 'px,' + (window.innerHeight + 60) + 'px) rotate(' + (360 + Math.random() * 540) + 'deg)', opacity: 0.9 }
      ], { duration: 2600 + Math.random() * 2200, delay: Math.random() * 700, easing: 'cubic-bezier(.3,.6,.4,1)', fill: 'forwards' });
    }
    setTimeout(function () { host.innerHTML = ''; }, 6500);
  }
})();
