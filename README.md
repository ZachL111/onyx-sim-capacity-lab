# onyx-sim-capacity-lab

`onyx-sim-capacity-lab` is a compact C# repository for simulations, centered on this goal: Create a C# reference implementation for capacity workflows, centered on visual model generation, layout fixtures, and stable geometry snapshots.

## Reason For The Project

The point is to make a small domain rule concrete enough that a reader can change it and immediately see what broke.

## Onyx Sim Capacity Lab Review Notes

`stale` and `stress` are the cases worth reading first. They show the optimistic and cautious ends of the fixture.

## What It Does

- `fixtures/domain_review.csv` adds cases for input pressure and state drift.
- `metadata/domain-review.json` records the same cases in structured form.
- `config/review-profile.json` captures the read order and the two review questions.
- `examples/onyx-sim-capacity-walkthrough.md` walks through the case spread.
- The C# code includes a review path for `input pressure` and `state drift`.
- `docs/field-notes.md` explains the strongest and weakest cases.

## How It Is Put Together

The repository has two validation layers: the original compact policy fixture and the domain review fixture. They are separate so one can change without hiding failures in the other.

The added C# path is deliberately direct, with fixtures doing most of the explaining.

## Run It

```powershell
powershell -NoProfile -ExecutionPolicy Bypass -File scripts/verify.ps1
```

## Check It

The same command runs the local verification path. The highest-scoring domain case is `stale` at 233, which lands in `ship`. The most cautious case is `stress` at 151, which lands in `ship`.

## Boundaries

The repository is intentionally scoped to local checks. I would expand it by adding adversarial fixtures before adding features.
