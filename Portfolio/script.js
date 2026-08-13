/* ========================================
   PORTFOLIO JAVASCRIPT
   ======================================== */

// ── Navbar scroll effect ──
const navbar = document.getElementById('navbar');
let lastScroll = 0;

window.addEventListener('scroll', () => {
  const currentScroll = window.scrollY;
  if (currentScroll > 50) {
    navbar.classList.add('scrolled');
  } else {
    navbar.classList.remove('scrolled');
  }
  lastScroll = currentScroll;
}, { passive: true });

// ── Hamburger / Mobile menu ──
const hamburger = document.getElementById('hamburger');
const mobileMenu = document.getElementById('mobile-menu');
const mobileLinks = document.querySelectorAll('.mobile-link');

hamburger.addEventListener('click', () => {
  hamburger.classList.toggle('active');
  mobileMenu.classList.toggle('open');
});

mobileLinks.forEach(link => {
  link.addEventListener('click', () => {
    hamburger.classList.remove('active');
    mobileMenu.classList.remove('open');
  });
});

// Close mobile menu on outside click
document.addEventListener('click', (e) => {
  if (!hamburger.contains(e.target) && !mobileMenu.contains(e.target)) {
    hamburger.classList.remove('active');
    mobileMenu.classList.remove('open');
  }
});

// ── Typing Animation ──
const typedEl = document.getElementById('typed-text');
const phrases = [
  'Aspiring .NET Developer',
  'C# Enthusiast',
  'CSE Student @ DIU',
  'Problem Solver',
  'Software Developer in the Making',
];

let phraseIndex = 0;
let charIndex = 0;
let isDeleting = false;
let typingTimeout;

function type() {
  const currentPhrase = phrases[phraseIndex];

  if (!isDeleting) {
    typedEl.textContent = currentPhrase.slice(0, charIndex + 1);
    charIndex++;
    if (charIndex === currentPhrase.length) {
      isDeleting = true;
      typingTimeout = setTimeout(type, 2000);
      return;
    }
  } else {
    typedEl.textContent = currentPhrase.slice(0, charIndex - 1);
    charIndex--;
    if (charIndex === 0) {
      isDeleting = false;
      phraseIndex = (phraseIndex + 1) % phrases.length;
    }
  }

  const speed = isDeleting ? 60 : 90;
  typingTimeout = setTimeout(type, speed);
}

setTimeout(type, 600);

// ── Scroll Reveal ──
const revealEls = document.querySelectorAll('.reveal-up, .reveal-left, .reveal-right');

const revealObserver = new IntersectionObserver((entries) => {
  entries.forEach(entry => {
    if (entry.isIntersecting) {
      entry.target.classList.add('visible');
      revealObserver.unobserve(entry.target);
    }
  });
}, {
  threshold: 0.12,
  rootMargin: '0px 0px -40px 0px',
});

revealEls.forEach(el => revealObserver.observe(el));

// Immediately reveal hero elements
document.querySelectorAll('.hero .reveal-up, .hero .reveal-right').forEach((el, i) => {
  el.style.transitionDelay = `${i * 0.1}s`;
  setTimeout(() => el.classList.add('visible'), 100 + i * 100);
});

// ── Skill Bar Animation ──
const skillFills = document.querySelectorAll('.skill-fill');

const skillObserver = new IntersectionObserver((entries) => {
  entries.forEach(entry => {
    if (entry.isIntersecting) {
      const fill = entry.target;
      const targetWidth = fill.dataset.width;
      setTimeout(() => {
        fill.style.width = targetWidth + '%';
      }, 200);
      skillObserver.unobserve(fill);
    }
  });
}, { threshold: 0.3 });

skillFills.forEach(fill => skillObserver.observe(fill));

// ── Counter Animation ──
const statNumbers = document.querySelectorAll('.stat-number');

function animateCounter(el) {
  const target = parseInt(el.dataset.target);
  const duration = 1800;
  const start = performance.now();

  function step(now) {
    const elapsed = now - start;
    const progress = Math.min(elapsed / duration, 1);
    // Easing: ease-out cubic
    const eased = 1 - Math.pow(1 - progress, 3);
    el.textContent = Math.floor(eased * target);
    if (progress < 1) requestAnimationFrame(step);
    else el.textContent = target;
  }

  requestAnimationFrame(step);
}

const counterObserver = new IntersectionObserver((entries) => {
  entries.forEach(entry => {
    if (entry.isIntersecting) {
      animateCounter(entry.target);
      counterObserver.unobserve(entry.target);
    }
  });
}, { threshold: 0.5 });

statNumbers.forEach(el => counterObserver.observe(el));

// ── Contact Form ──
const form = document.getElementById('contact-form');
const submitBtn = document.getElementById('submit-btn');
const formSuccess = document.getElementById('form-success');

if (form) {
  form.addEventListener('submit', (e) => {
    e.preventDefault();

    // Simple validation
    const name = form.querySelector('#name').value.trim();
    const email = form.querySelector('#email').value.trim();
    const subject = form.querySelector('#subject').value.trim();
    const message = form.querySelector('#message').value.trim();

    if (!name || !email || !subject || !message) return;

    // Simulate submission
    submitBtn.disabled = true;
    submitBtn.querySelector('.btn-text').textContent = 'Sending...';

    setTimeout(() => {
      form.reset();
      submitBtn.disabled = false;
      submitBtn.querySelector('.btn-text').textContent = 'Send Message';
      formSuccess.classList.add('show');
      setTimeout(() => formSuccess.classList.remove('show'), 5000);
    }, 1500);
  });
}

// ── Active nav link on scroll ──
const sections = document.querySelectorAll('section[id]');
const navLinks = document.querySelectorAll('.nav-link');

const activeSectionObserver = new IntersectionObserver((entries) => {
  entries.forEach(entry => {
    if (entry.isIntersecting) {
      const id = entry.target.getAttribute('id');
      navLinks.forEach(link => {
        link.classList.remove('active');
        if (link.getAttribute('href') === `#${id}`) {
          link.classList.add('active');
        }
      });
    }
  });
}, { threshold: 0.4 });

sections.forEach(sec => activeSectionObserver.observe(sec));

// ── Nav link active style ──
const style = document.createElement('style');
style.textContent = `
  .nav-link.active {
    color: var(--clr-text) !important;
  }
  .nav-link.active::after {
    width: 100% !important;
  }
`;
document.head.appendChild(style);

// ── Smooth hover on project cards ──
document.querySelectorAll('.project-card').forEach(card => {
  card.addEventListener('mouseenter', () => {
    card.style.willChange = 'transform';
  });
  card.addEventListener('mouseleave', () => {
    card.style.willChange = 'auto';
  });
});

console.log('%c✨ Portfolio loaded successfully!', 'color: hsl(25, 75%, 45%); font-size: 14px; font-weight: bold;');
