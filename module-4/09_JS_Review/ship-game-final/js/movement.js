/**
 * Moves the ship one tile up
 */
function moveShipUp() {
    const shipTile = getShipLocation();
    const tileAboveShip = getElementAtSameIndex(shipTile, shipTile.parentElement.previousElementSibling);
    moveShip(shipTile, tileAboveShip);
}

/**
 * Moves the ship one tile down
 */
function moveShipDown() {
    const ship = getShipLocation();
    const down = getElementAtSameIndex(ship, ship.parentElement.nextElementSibling);
    moveShip(ship, down);
}

/**
 * Moves the ship one tile right
 */
function moveShipRight() {
    const ship = getShipLocation();
    const right = ship.nextElementSibling;
    moveShip(ship, right);
}

/**
 * Moves the ship one tile left
 */
function moveShipLeft() {
    const ship = getShipLocation();
    const left = ship.previousElementSibling;
    moveShip(ship, left);
}

/**
 * Moves the boat from the current tile to the new tile
 * @param {Node} currentTile the current tile of the ship
 * @param {Node} newTile the new tile that should contain the ship
 */
function moveShip(currentTile, newTile) {
    if (canMoveToElement(newTile)) {
        currentTile.classList.remove('boat');
        newTile.classList.add('boat');

        if (containsTreasure(newTile)) {
            handleGameWon();
        }
    }
}

/**
 * Determines whether or not the boat can move to the specified element.
 * This will be true unless the element is null (off the map) or has a pirate.
 * @param {Node} element the square the boat wants to move to
 * @returns {boolean} whether or not the boat can move to the square
 */
function canMoveToElement(element) {
    return element && !element.classList.contains('pirate');
}