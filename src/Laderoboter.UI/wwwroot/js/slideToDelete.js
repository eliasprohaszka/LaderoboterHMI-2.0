let dotNetRef = null;
let trackElement = null;
let maxPosition = 0;
let startX = 0;
let currentPosition = 0;
let isDragging = false;

export function initSlider(dotNetReference, track, maxPos) {
    dotNetRef = dotNetReference;
    trackElement = track;
    maxPosition = maxPos;
    currentPosition = 0;
    isDragging = false;

    document.addEventListener('mousemove', handleMouseMove);
    document.addEventListener('mouseup', handleMouseUp);
    document.addEventListener('touchmove', handleTouchMove, { passive: false });
    document.addEventListener('touchend', handleTouchEnd);

    if (trackElement) {
        const thumb = trackElement.querySelector('.slide-thumb');
        if (thumb) {
            thumb.addEventListener('mousedown', handleMouseDown);
            thumb.addEventListener('touchstart', handleTouchStart, { passive: false });
        }
    }
}

function handleMouseDown(e) {
    e.preventDefault();
    isDragging = true;
    startX = e.clientX - currentPosition;
}

function handleTouchStart(e) {
    e.preventDefault();
    if (e.touches.length > 0) {
        isDragging = true;
        startX = e.touches[0].clientX - currentPosition;
    }
}

function handleMouseMove(e) {
    if (!isDragging || !dotNetRef) return;

    const newPosition = e.clientX - startX;
    currentPosition = Math.max(0, Math.min(newPosition, maxPosition));

    dotNetRef.invokeMethodAsync('UpdateSliderPosition', currentPosition);
}

function handleTouchMove(e) {
    if (!isDragging || !dotNetRef) return;
    e.preventDefault();

    if (e.touches.length > 0) {
        const newPosition = e.touches[0].clientX - startX;
        currentPosition = Math.max(0, Math.min(newPosition, maxPosition));

        dotNetRef.invokeMethodAsync('UpdateSliderPosition', currentPosition);
    }
}

function handleMouseUp() {
    if (!isDragging || !dotNetRef) return;

    isDragging = false;
    dotNetRef.invokeMethodAsync('EndDrag');
}

function handleTouchEnd() {
    if (!isDragging || !dotNetRef) return;

    isDragging = false;
    dotNetRef.invokeMethodAsync('EndDrag');
}

export function disposeSlider() {
    document.removeEventListener('mousemove', handleMouseMove);
    document.removeEventListener('mouseup', handleMouseUp);
    document.removeEventListener('touchmove', handleTouchMove);
    document.removeEventListener('touchend', handleTouchEnd);

    if (trackElement) {
        const thumb = trackElement.querySelector('.slide-thumb');
        if (thumb) {
            thumb.removeEventListener('mousedown', handleMouseDown);
            thumb.removeEventListener('touchstart', handleTouchStart);
        }
    }

    dotNetRef = null;
    trackElement = null;
}
