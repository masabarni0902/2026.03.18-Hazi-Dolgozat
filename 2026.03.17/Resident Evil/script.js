function toggleDesc(header) {
  const card = header.parentElement;
  const desc = card.querySelector('.movie-description');
  const isCurrentlyOpen = card.classList.contains('active');

  // Csak a MÁSIK kártyákat zárjuk be
  document.querySelectorAll('.movie-card').forEach(otherCard => {
    if (otherCard !== card) {                     // ← ezt hozzáadni!
      otherCard.classList.remove('active');
      const otherDesc = otherCard.querySelector('.movie-description');
      otherDesc.style.maxHeight = '0px';
    }
  });

  // Most már normálisan toggle-elhetünk
  if (isCurrentlyOpen) {
    // bezárás
    card.classList.remove('active');
    desc.style.maxHeight = '0px';
  } else {
    // kinyitás
    card.classList.add('active');
    requestAnimationFrame(() => {
      desc.style.maxHeight = desc.scrollHeight + 'px';
    });
  }
}

function openModal(type) {
  document.getElementById(type + 'Modal').style.display = 'flex';
}

function closeModal(type) {
  document.getElementById(type + 'Modal').style.display = 'none';
}

function switchModal(from, to) {
  closeModal(from);
  openModal(to);
}

window.onclick = function(event) {
  if (event.target.classList.contains('modal')) {
    event.target.style.display = 'none';
  }
};