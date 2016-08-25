
namespace MarketsInfo.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            if (!context.Users.Any())
            {
                // If the database is empty, populate sample data in it

                CreateUser(context, "admin@gmail.com", "123", "System Administrator");
                CreateUser(context, "yasha@gmail.com", "123", "Yashaswini Swamynathan");
                CreateUser(context, "merry@gmail.com", "123", "Maria Petrova");
                CreateUser(context, "david@gmail.com", "123", "David Ingram");
                CreateUser(context, "ellen@gmail.com", "123", "Ellen R. Wald");

                CreateRole(context, "Administrators");
                AddUserToRole(context, "admin@gmail.com", "Administrators");

                CreatePost(context,
                    title: "Germany's new electric car discount scheme draws nearly 2,000 applicants",
                    body: @"<p>BERLIN (Reuters) - Nearly 2,000 people in Germany have applied for the government's electric car discount scheme, introduced on July 1, and a third of them are buyers of BMW (DE:BMWG) models, a government agency said on Thursday.</p>
<p>The scheme, similar to those established in other European countries to spur electric car sales, grants buyers of electric cars a 4,000 euro($4,452.00) discount and gives buyers of plug-in hybrid vehicles a discount of 3,000 euros.</p>
<p>Since its introduction, 1,791 buyers of electric or plug-in hybrid vehicles have applied for the discounts and 581 of them were buyers of BMW models, notably its i3 electric car, the BAFA economic affairs and export control agency said. BMW has pioneered the production of such cars in Germany and offers more models than other carmakers.</p>
<p>There were 444 applications for the discounts from buyers of Renault (PA:RENA) models and 154 applications from buyers of Volkswagen (DE:VOWG_p) models, BAFA said.</p>
<p>The total 1.2 billion euro ($1.3 billion) cost of the incentives is being shared equally between the German government and carmakers, with a goal of selling around 400,000 electric cars in Europe's biggest car market.</p>
<p>Out of the 45 million cars on German roads, only about 50,000 are purely battery-powered vehicles or plug-in hybrids.
The incentive scheme expires at the end of June 2019, BAFA said.</p>
<p>BAFA said 1,194 requests for the discounts on electric cars and 597 requests for plug-in hybrid discounts have been submitted, adding a third of all requests were filed on behalf of companies.</p>",
                    date: new DateTime(2016, 03, 27, 17, 53, 48),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "New U.S. mortgage rules aim to stop wrongful foreclosures",
                    body: @"<p>WASHINGTON (Reuters) - The U.S. agency charged with protecting consumers' finances approved rules on Thursday that will help prevent wrongful home foreclosures, as the regulator continues to press on with reforming the country's massive lending market.</p>
<p>The rules by the Consumer Financial Protection Bureau (CFPB), created in the aftermath of the U.S. housing bust that began in 2006, build on current regulations requiring a mortgage servicer to grant certain foreclosure protections to a struggling borrower once over the life of the loan.</p>
<p>Now, servicers, the conduits for mortgage payments, must provide those protections more than once, offering them to borrowers who make current payments after they have worked out an agreement to avoid foreclosure.</p>
<p>""This change will be particularly helpful for borrowers who obtain a permanent loan modification and later suffer an unrelated hardship – such as the loss of a job or the death of a family member – that could otherwise cause them to face foreclosure,"" the CFPB said in an outline of the new rules.</p>
<p>The rules also expand consumer protections to surviving family members and require servicers to give borrowers in bankruptcy information about possible interventions.</p>
<p>They bolster requirements related to loss mitigation, a foreclosure alternative that allows people to stay in their homes and pay some money to lenders, as well.</p>
<p.Servicers will have to promptly notify borrowers when loss mitigation applications are complete, and will not be able to ""dual track,"" where they take legal steps toward foreclosure at the same time they evaluate the applications.</p>.
<p>""The Consumer Bureau is committed to ensuring that homeowners and struggling borrowers are treated fairly by mortgage servicers and that no one is wrongly foreclosed upon,” CFPB Director Richard Cordray said in a statement.</p>
<p>In a June report, the CFPB showed some servicers are giving homeowners wrong or outdated information, or no information at all.
When mortgage defaults spiked during the 2007-09 financial crisis, servicers came under intense scrutiny for missing paperwork, incomplete documentation, and ""robosigning,"" where employees signed off on foreclosures without review.</p>
<p>A crisis-era Treasury program that allows struggling borrowers to reduce their monthly payments and prevent foreclosure will expire in January.</p>
<p>On Tuesday, the CFPB said it was looking into crafting new debt relief programs and released the principles guiding its work, which emphasized giving consumers easy access to information about loss mitigation and the decisions servicers make on their loans and creating repayment plans and loan modifications that are affordable.</p>",
                    date: new DateTime(2016, 05, 11, 08, 22, 03),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "Business groups sue over new U.S. limit on tax-driven foreign buyouts",
                    body: @"<p>NEW YORK/WASHINGTON (Reuters) - Two business groups sued the Obama administration on Thursday over a crackdown on U.S. companies that try to reduce their U.S. taxes by rebasing abroad in a process known as inversion.</p>
<p>The U.S. Chamber of Commerce and the Texas Association of Business filed a lawsuit in Texas federal court that said a regulation from the <p>U.S. Treasury Department in April exceeded what the law allows the department to do.</p>
The lawsuit was the first to challenge a rule on inversion. The deals are legal, but have drawn criticism from some politicians who say U.S. companies that do them are avoiding their tax obligations. A wave of inversions largely ended after Treasury moved against the deals.
The rule targeted by the lawsuit is aimed at transactions involving non-U.S. companies, such as Ireland-based drugmaker Allergan Plc (N:AGN) that have grown through a series of acquisitions.</p>
<p>It helped scuttle what had been a planned $160 billion combination of Allergan and U.S. drugmaker Pfizer Inc (N:PFE) in what would have been the largest inversion ever.</p>
<p>""Treasury and the IRS ignored the clear limits of a statute, and simply rewrote the law unilaterally. This is not the way government is supposed to work in America,"" Tom Donohue, head of the chamber, a business lobbying group, said in a statement.</p>.
<p>A Treasury spokeswoman declined to comment.</p>
<p>UPHILL BATTLE</p>
<p>Lawyers with expertise in tax law have said such a lawsuit would face an uphill battle against Treasury, which has a strong record in court. The 1867 Anti-Injunction Act says that, in general, no legal challenge can be brought against a tax until it is assessed. So the administration of President Barack Obama could argue that the law bars a lawsuit for now.</p>
<p>""I would be quite surprised if this case survived the obvious defense by the Justice Department that this is an attempt to short-circuit the regular course of tax collections,"" said Edward Kleinbard, a law professor at the University of Southern California.</p>
<p>The chamber and the Texas Association of Business argue, though, that the Treasury and the tax-collecting Internal Revenue Service must still follow a different law, the Administrative Procedure Act (APA). That law spells out the process agencies must follow before they impose regulations.</p>
<p>According to the lawsuit, the Treasury rule violated the APA because Treasury lacked authority to act, its rule was arbitrary and capricious, and it did not permit public notice and comment.</p>
<p>Allergan and Pfizer are not parties to the lawsuit, but the lawsuits cites their failed merger as an example of the harm done by the rule.
Representatives of the companies declined to comment on the litigation.</p>
<p>Pfizer is a member of the chamber and the Texas Association of Business. Allergan is a member of the chamber and the Greater Waco Chamber of Commerce, which in turn is a member of the Texas group, the lawsuit said.</p>
<p>The two drug companies ""would actively explore merger opportunities"" if the rule were set aside, the lawsuit said.
DOZENS OF DEALS</p>
<p>Dozens of U.S. companies have done inversions since 1983, when the first such deal was completed. Treasury has periodically moved to curb the flow of deals because inversions erode the U.S. corporate income tax base.</p>
<p>Treasury unveiled a package of rules in April meant to further discourage the deals, which typically involve a U.S. multinational buying a smaller company in a foreign country with lower corporate taxes and then rebasing there, if only on paper.</p>
<p>Inverting U.S. companies usually leave their core U.S. operations at home, transferring only their legal tax domicile to the home country of the acquired company. Recent popular destinations for the deals are Ireland, Britain and Canada.</p>
<p>Fast food chain Burger King inverted to Canada last year; medical technology group Medtronic (N:MDT) to Ireland in 2014; drug maker Mylan Inc (O:MYL) to The Netherlands that same year.</p>
<p>The lawsuit challenges a specific rule that imposed a three-year limit on foreign companies such as Allergan bulking up on U.S. assets to avoid ownership thresholds for a later inversion.</p>
<p>In April, Treasury defended its regulation in a statement that said it was ""not consistent with the purposes"" of federal law to permit a foreign company to bulk up so quickly and then enter into another inversion.</p>
<p>Texas federal courts have been a friendly venue for groups suing the Obama administration. A judge there blocked the president's proposed overhaul of immigration.</p>
<p>More litigation is expected in the months ahead as Treasury moves to finalize another anti-inversions rule targeting ""earnings stripping,"" a tax-avoiding practice in which a foreign parent lends money to a U.S. unit, which sends U.S. profits back as partially U.S. tax-deductible interest.</p>
<p>Republicans, and at times Obama, have pushed for a comprehensive tax code overhaul that would fully address inversions, but Washington for decades has lacked the political will to tackle such a complex project.</p>",

                  date: new DateTime(2016, 07, 27, 17, 53, 48),
                    authorUsername: "david@gmail.com"
                );

                CreatePost(context,
                    title: "Crude jumps 2% extending rally from 3-month lows, amid short covering",
                    body: @"<p>Investing.com -- Crude futures rose sharply on Thursday, amid heavy short covering, as oil prices continued to rebound from a lengthy midsummer rout, one day after reports indicated that the massive supply glut in gasoline inventories could be showing signs of leveling.</p>
<p>On the New York Mercantile Exchange, WTI crude for September delivery traded between $40.45 and $42.08 a barrel before closing at $41.84, up 1.01 or 2.47% on the session. Earlier this week, the front month contract for U.S. crude futures closed below $40 for the first time since mid-April, capping a lengthy five-week downturn after hitting 10-month highs at the start of the summer. On the Intercontinental Exchange (ICE), brent crude for October delivery wavered between $42.52 and $44.33 a barrel, before settling at $44.23, up 1.12 or 2.60% on the day.</p>
<p.The international and U.S. domestic benchmarks for crude are still down more than 15% from their June highs.</p>
<p>In Thursday's session, market players continued to digest a surprising draw in gasoline inventories last week when stockpiles nationwide fell by 3.3 million barrels for the week ending on July 29. It came amid mounting fears among analysts of a massive supply glut in recent weeks, as refineries churn out product at a rapid pace due to comparatively low oil prices. In spite of the massive decline, total petroleum inventories have still spiked by approximately 25 million barrels over the last two months, according to analysts.</p>
<p>Investors turn their attention to Friday's weekly rig count from Baker Hughes for clearer indications on the rate of drilling activity throughout the U.S. Last week, Baker Hughes reported that the U.S. oil rig count rose by three to 374 for the week ending on July 22, representing the fifth consecutive week of weekly gains.</p>
<p>High cost U.S. shale producers have seen their global market share wane, as prices remain sharply below their peak of $115 a barrel from two summers ago. In November, 2014, OPEC rattled global energy markets by maintaining their production ceiling above 30 million barrels per day in an effort to regain market share. The strategy triggered a prolonged battle between leading producers in the Middle East and the U.S. for control of oil markets worldwide, creating an imbalance between global supply and demand.</p>
<p>Analysts from the Institute of International Finance (IIF) estimated this week that OPEC could control as much as 46% of global supply by 2020, nearly matching its peak from forty years ago. At the same time, the IIF predicts that global oil demand will increase by 1.4 million bpd in 2016, before rising by another 1.3 million bpd by the end of next year. As a steady increase in demand is met by only a moderate increase in global supply, the IIF estimates that oil prices will remain in a range between $40 and $50 a barrel through the end of 2017.
The U.S. Dollar Index, which measures the strength of the greenback versus a basket of six other major currencies, gained more than 0.20% to an intraday high 95.87. The index is still sharply below four-month highs of 97.62 from early last week.</p>
<p>Dollar-denominated commodities such as Crude become more expensive for foreign purchasers when the dollar appreciates.</p>
",
                    date: new DateTime(2016, 02, 18, 22, 14, 38),
                    authorUsername: "merry@gmail.com"
                );

                CreatePost(context,
                    title: "Airbus closes on rival Boeing in jet order race",
                    body: @"<p>PARIS/NEW YORK (Reuters) - Airbus (PA:AIR) virtually closed the gap with Boeing in their intense battle for airliner orders in July after booking about half of the 197 firm sales unveiled at last month's Farnborough Airshow, according to the latest data from both companies.</p>
<p>Amid a broad slowdown in purchases, the European planemaker said it had sold a total of 373 jets between January and July, or 323 after adjusting for cancellations.</p>
<p>That compares with 383 airplane sales, or 333 after cancellations, notched up by U.S. rival Boeing (N:BA).
Combined orders at the world's dominant planemakers fell 17 percent from the same period last year, weighed by concerns over the economy and relatively low oil prices which have taken the edge off demand for new fuel-saving models.</p>
<p>Both planemakers are also struggling to book new sales in a market that is seen as somewhat oversupplied with jets, especially larger wide-body models, industry experts said.</p>
<p>The slowdown has raised some questions about whether they will maintain plans to boost output later this decade.
Both have also faced a slew of order deferrals in recent weeks, while insisting the trend of postponements is stable.
Two industry sources said Indonesia's Lion Air, one of the largest Asian jet buyers with hundreds of jets on order from Boeing and Airbus, is aiming to defer about 25 Airbus jets.</p>
<p>Airbus declined comment and Lion Air was not available.</p>
<p>The planemaker was also hammering out last details of an order for 100 more planes from Lion Air's regional rival AirAsia (KL:AIRA), announced in a shower of publicity at Farnborough.</p>
<p>After a slow start to the year, Airbus had looked set to end the Farnborough Airshow with 380 net orders for the year to date including the AirAsia deal, which it described as a firm order.</p>
<p>The deal did not make it into the new tally, however, and an Airbus spokesman said paperwork was being finalised. A person close to the talks said they only involved tying up loose ends.</p>
<p>Latest Airbus data also suggested that another order secured at the height of an industry boom in 2012 had been trimmed back.
Mexican low-cost carrier Interjet has canceled five of 40 A320neo jets it has on order, according to Thursday's update.</p>
<p>No immediate comment was available from the airline on the disclosure, which comes as Mexican consumer confidence drops to its lowest level in two years amid a weak economy.</p>
<p>DELIVERY</p>
<p>While Boeing remains ahead by a whisker in the race for new orders, it maintains a solid lead on deliveries which drive revenues, handing over 432 jets between January and July.</p>
<p>Airbus delivered 339 jets between January and July, down 4 percent on the year, due in part to a shortage of Pratt & Whitney (UTX.N> engines for its latest model, the revamped A320neo.</p>
<p>Airbus delivered just three of the jets in July, including two powered by Pratt & Whitney and the first to be delivered with alternative engines from CFM International (N:GE) (PA:SAF).</p>
<p>So far this year it has delivered 11 A320neos and 15 of its widebody A350s, another model suffering delays due in part to problems with suppliers. It aims to deliver 50 A350s this year.<p>
<p>Industry sources say that besides widely reported problems with cabin equipment such as toilets, the A350 has faced some other glitches including quality problems with wing spoilers from Austrian parts maker FACC (VI:FACC). An Airbus spokesman said these problems had been resolved. FACC declined to comment.</p>
<p>New Airbus data also incorporated the cancellation by Qatar Airways of the first of 50 A320neo-family jets it has ordered.
The Gulf airline has criticized Airbus and Pratt & Whitney over A320neo delays and said in June it would exercise a clause to abandon the first jet, one of several parked in Qatar livery outside the French factory waiting for engines.</p>
<p>Parent Airbus Group said last week that upgraded versions of the engines were now being delivered.
Meanwhile, Qatar Airways is in talks with Boeing for rival 737 MAX jets to diversify its fast-expanding fleet.</p>",
                    date: new DateTime(2016, 04, 11, 19, 02, 05),
                    authorUsername: "aneta@gmail.com"
                );

                CreatePost(context,
                    title: "Wall Street flat as investors hold off ahead of jobs data",
                    body: @"<p>(Reuters) - Wall Street was little changed on Thursday as investors were wary of making big bets ahead of Friday's payrolls report.</p>
<p>The crucial monthly hiring data will help investors gauge the health of the economy and offer clues about when the Federal Reserve could pull the trigger on rates.</p>
<p>""Today is more of a consolidation of positions. Perhaps taking some chips off the table ahead of tomorrow's jobs number,"" said Tony Bedikian, head of global markets at Citizens Bank.</p>
<p>""The Fed would perhaps need one more strong payroll number before it makes a move.""</p>
<p>Traders have priced in a 12 percent chance of a rate hike in September and a 35 percent chance in December, according to CME Group's FedWatch tool.</p>
<p>At 12:32 p.m. ET (1632 GMT), the Dow Jones Industrial Average (DJI) was up 1.95 points, or 0.01 percent, at 18,356.95.
The S&P 500 index (SPX) was up 2.09 points, or 0.1 percent, at 2,165.88.
The Nasdaq Composite (IXIC) was up 9.20 points, or 0.18 percent, at 5,168.94.</p>
<p>The Bank of England lowered its key lending rate to 0.25 percent from 0.5 and said it would take ""whatever action is necessary"" to achieve stability in the wake of Britain's vote to leave the European Union.</p>
<p>Seven of the 10 major S&P 500 sectors were higher, led by a 0.52 percent gain in the information technology index (SPLRCT).
A rebound in oil prices helped reverse losses in the energy sector (SPNY), which rose 0.21 percent. [O/R]
Facebook's (O:FB) stock rose 1.6 percent to $124.50 and was the biggest driver of the S&P and the Nasdaq.
Metlife (N:MET) dropped nearly 10 percent after the largest U.S. life insurer's quarterly profit missed estimates.
Ball Corp (N:BLL) jumped 8.5 percent after its quarterly sales rose and was the top percentage gainer on the S&P 500.
LinkedIn (N:LNKD) which has agreed to be bought by Microsoft (O:MSFT), and Kraft Heinz (O:KHC) are scheduled to report after the bell.
Advancing issues outnumbered decliners on the NYSE by 1,783 to 1,073. On the Nasdaq, 1,508 issues rose and 1,185 fell.
The S&P 500 index showed 16 new 52-week highs and one new low, while the Nasdaq recorded 66 new highs and 27 new lows.</p>",
                    date: new DateTime(2016, 06, 30, 17, 36, 52),
                    authorUsername: "yasha@gmail.com"
                );

                CreatePost(context,
                    title: "Here's How OPEC Manipulates The Oil Market",
                    body: @" <p>Tuesday’s <span class=""aqPopupWrapper js-hover-me-wrapper""><a href=""/commodities/crude-oil"" id=""57bdc2e81516f"" class=""aqlink js-hover-me"" hoverme=""aql"" data-pairid=""8849"">oil</a></span> market has proven, once again, that OPEC can play the speculation game too.</p>
<p>Last week, the price of oil was slowly climbing back up to $50 a barrel, apparently based on reports that OPEC leaders were planning to meet to discuss a production freeze at the end of September. At the start of this week, however, the media reported that most analysts do not believe that OPEC will agree to a production freeze (an obvious conclusion), that the number of <span class=""aqPopupWrapper js-hover-me-wrapper""><a href=""/economic-calendar/baker-hughes-u.s.-rig-count-1652"" id=""57bdc2e815517"" class=""js-hover-me"" hoverme=""eel"" data-eventid=""1652"">new oil rigs</a></span> in the U.S. <a href=""http://www.businessinsider.com/baker-hughes-rig-count-august-19-2016-8"" target=""_blank"" rel=""nofollow"">is increasing</a>, and that <a href=""http://www.reuters.com/article/us-iraq-oil-foreign-idUSKCN10Y0XI"" target=""_blank"" rel=""nofollow"">Iraq</a> is planning to increase oil exports. The price of oil began to decline.</p>
<p>Then, suddenly, around midday on Tuesday, the price of oil shot up by almost $1.50. The culprit? A Reuter’s <span class=""aqPopupWrapper mediumTitle1 js-hover-me-wrapper""><a href=""/news/commodities-news/oil-prices-fall-as-analysts-say-market-still-oversupplied-421752"" id=""57bdc2e815884"" class=""js-hover-me"" hoverme=""oal"" data-articleid=""421752"">report</a></span> based on an unnamed OPEC source, that Iran might be interested in “joint action,” to support oil prices. Despite the fact that the Iranian Oil Ministry has not even confirmed that Iran will attend the September meeting in Algeria, speculators saw the headline and ran with it.</p>
<p>Iran has no incentive to curtail its oil production. The country needs money desperately and has just overcome a major political hurdle on the way to offering new types of petroleum development contracts (called <a href=""http://www.shana.ir/en/newsagency/267470/IPC-in-no-Contrast-with-Resistive-Economy-Expert"" target=""_blank"" rel=""nofollow"">Iran Petroleum Contracts</a> or IPCs) to investors. Agreeing to freeze its oil production at current levels would send a message to investors that Iran is not open for petroleum development and would severely limit the country’s ability to increase its revenue in the future. Iran <a href=""http://www.shana.ir/en/newsagency/267470/IPC-in-no-Contrast-with-Resistive-Economy-Expert"" target=""_blank"" rel=""nofollow"">cannot</a> do that.</p>
<p>What Iran and other OPEC countries can do, however, is play the speculation game. Given that all oil producing countries and companies (with exceptions for destitute countries like <a href=""http://www.forbes.com/sites/ellenrwald/2016/08/11/venezuela-is-drowning-in-its-own-oil/#7863bd87da9a"" target=""_blank"" rel=""nofollow"">Venezuela</a>) are producing at high rates, and given that global demand is not increasing at the same rates, the price of oil is stuck below a certain threshold and above another.</p>
<p>Within this price range, however, certain producing countries (such as Iran, Saudi Arabia, Iraq, Russia) have found that they can easily manipulate oil traders with words. While past oil ministers, such as the recently retired Ali al-Naimi from Saudi Arabia, often <a href=""http://fingfx.thomsonreuters.com/gfx/ce/1/482/482/NAIMI%20AT%20CERA%20WEEK.pdf"" target=""_blank"" rel=""nofollow"">chastised</a> speculators for their finicky reactions to his every word, the current generation is taking advantage. It seems that OPEC ministers are now manipulating the manipulators. They issue cryptic statements that are not lies but are not substantive either. These statements serve to raise prices while the countries continue overproducing. All they have to do to raise the price by a couple of percentage points is issue a statement or two about a possible meeting or a hope to “stabilize the market.” They wait a day, or an hour, and speculators take the bait, pushing up the price of oil.</p>
<p>This week has shown that the speculators have taken the bait yet again.</p>",

                     date: new DateTime(2016, 08, 24, 19, 00, 00),
                    authorUsername: "ellen@gmail.com"
                );

                context.SaveChanges();
            }
        }

        private void CreateUser(ApplicationDbContext context,
            string email, string password, string fullName)
        {
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            userManager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 1,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = false,
            };

            var user = new ApplicationUser
            {
                UserName = email,
                Email = email,
                FullName = fullName
            };

            var userCreateResult = userManager.Create(user, password);
            if (!userCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", userCreateResult.Errors));
            }
        }

        private void CreateRole(ApplicationDbContext context, string roleName)
        {
            var roleManager = new RoleManager<IdentityRole>(
                new RoleStore<IdentityRole>(context));
            var roleCreateResult = roleManager.Create(new IdentityRole(roleName));
            if (!roleCreateResult.Succeeded)
            {
                throw new Exception(string.Join("; ", roleCreateResult.Errors));
            }
        }

        private void AddUserToRole(ApplicationDbContext context, string userName, string roleName)
        {
            var user = context.Users.First(u => u.UserName == userName);
            var userManager = new UserManager<ApplicationUser>(
                new UserStore<ApplicationUser>(context));
            var addAdminRoleResult = userManager.AddToRole(user.Id, roleName);
            if (!addAdminRoleResult.Succeeded)
            {
                throw new Exception(string.Join("; ", addAdminRoleResult.Errors));
            }
        }

        private void CreatePost(ApplicationDbContext context,
            string title, string body, DateTime date, string authorUsername)
        {
            var post = new News();
            post.Title = title;
            post.Body = body;
            post.date = date;
            post.Author = context.Users.Where(u => u.UserName == authorUsername).FirstOrDefault();
            context.News.Add(post);
        }
    }
}
