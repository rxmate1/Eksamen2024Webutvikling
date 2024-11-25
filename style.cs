       <footer id="Kontakt">
            <section id="Logo">
                <h3>Logo</h3>
                <p>sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt </p>
            </section>
            <section id="Kontakt-oss-Snarveier">
                <section id="Kontakt-oss">
                    <h3>Kontakt</h3>
                    <section>
                        <section>
                            <section class="ikon-footer">
                                <i class="fa-solid fa-location-dot"></i>
                            </section>
                            <h4>Adresse:</h4>
                            <p>B R A Veien 4, 1757 Halden</p>
                        </section>
                        <section>
                            <section>
                                <i class="fa-solid fa-phone"></i>
                            </section>
                            <h4>Telefon:</h4>
                            <p>69 60 80 00</p>
                        </section>
                        <section>
                            <section>
                                <i class="fa-solid fa-envelope"></i>
                            </section>
                            <h4>E-post:</h4>
                            <p>halden@hiof.no</p>
                        </section>
                        <section>
                            <section>
                                <i class="fa-solid fa-clock"></i>
                            </section>
                            <h4>Åpningstider:</h4>
                            <p>Stenger 15:00</p>
                        </section>

                    </section>
                </section>
                <section id="Snarveier">
                    <h3>Snarveier</h3>
                    <a href="#">Produkter</a>
                    <a href="#">Kategorier</a>
                    <a href="#">Kontakt oss</a>
                </section>
            </section>
            <section id="Sosiale-medier">
                <h3>Sosiale medier</h3>
                <a href="https://www.instagram.com" target="_blank">
                    <i class="fa-brands fa-instagram"></i>
                </a>
                <a href="https://www.facebook.com" target="_blank">
                    <i class="fa-brands fa-facebook"></i>
                </a>
                <a href="https://www.linkedin.com" target="_blank">
                    <i class="fa-brands fa-linkedin"></i>
                </a>
                <a href="https://www.pinterest.com" target="_blank">
                    <i class="fa-brands fa-pinterest"></i>
                </a>
            </section>
        </footer>





        #grid-container_2 {
    display: grid; /* Enables grid layout */
    grid-template-columns: repeat(1, 1fr); /* Default: 1 column for mobile */
    gap: 1.5rem; /* Spacing between grid items */
    width: 100%;
    padding: 10px;
    box-sizing: border-box;
}

/* Tablet view: 2 columns */
@media (min-width: 768px) {
    #grid-container_2 {
        grid-template-columns: repeat(2, 1fr); /* 2 columns for tablets */
    }
}

/* Desktop view: 3 columns */
@media (min-width: 1024px) {
    #grid-container_2 {
        grid-template-columns: repeat(3, 1fr); /* 3 columns for desktops */
    }
}

/* Individual Category Cards */
.Category-card {
    display: flex;
    flex-direction: column;
    align-items: center;
    max-height: 300px;
    width: 100%; /* Ensures the card fits within the grid cell */
    background-color: #000000;
    border-radius: 25px;
    overflow: hidden;
    position: relative;
}

/* Category Image */
.Category-card .Kategori-bilder {
    width: 100%;
    height: auto;
    object-fit: cover;
    border-radius: 25px;
    filter: blur(3px);
}

/* Category Name */
.Category-card .Category-name {
    position: absolute;
    top: 0;
    left: 0;
    height: 100%;
    width: 100%;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
    text-align: center;
    color: rgb(255, 255, 255);
    box-sizing: border-box;
}

/* Section Title */
#grid-container_2 section h2 {
    grid-column: 1 / -1; /* Spans the full width of the grid */
    text-align: center;
    font-size: 2rem;
    margin-bottom: 0.5rem;
}

/* Section Subtitle */
#grid-container_2 section p {
    grid-column: 1 / -1; /* Spans the full width of the grid */
    text-align: center;
    font-size: 1rem;
    margin-bottom: 1rem;
}